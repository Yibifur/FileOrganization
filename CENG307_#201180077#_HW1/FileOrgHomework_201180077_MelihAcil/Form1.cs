using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace CENG307_201180077_HW1
{

    /*
    * File Organization CENG 307
    * Homework 1
    * Reisch and Binary Tree
    * 
    * 201180077
    * Melih AÇIL
    */

    public partial class Form1 : Form
    {

        //Arrays that hold values 
        private Data[] dataReisch;
        private DataBT[] binaryTreeData;
        private int[] values;

        //Queue to implement binary tree in bfs form
        Queue<QueueData> nodeQueue;
        // Queue to search in binary tree
        Queue<int[]> binaryTreeSearchQueue;
        private Random random;

        private int arraySize;
        private int randomMax;

        private int randomLocation;
        private int primeNumber;

        public Form1()
        {
            InitializeComponent();
        }
        //Generate button that randomizes an array then runs reisch and binary tree methods
        private void button1_Click(object sender, EventArgs e)
        {
            //Clearing data from listviews
            verilerListView.Items.Clear();
            reischListView.Items.Clear();
            btListView.Items.Clear();
            arraySize = Convert.ToInt32(randomArrSize.Text);
            randomMax = Convert.ToInt32(textMax.Text);

            RandomGenerator();
            REISCH_Algorithm();
            Binarytree_Hashing();
            Info_Function();    
        }
        //Random generator and initializing process
        private void RandomGenerator()
        {
            getPrimeKey();
            //Creating array for main values
            values = new int[arraySize];
            random = new Random();

            dataReisch = new Data[primeNumber];
            binaryTreeData = new DataBT[primeNumber];
            values[0] = 1;
            //Assigning random values (no duplicates)
            for (int i = 0; i < arraySize; i++)
            {
                int temp = random.Next(0, randomMax);
                //If it does contain a duplicate then go back one step
                if (values.Contains(temp))
                    i--;
                else
                {
                    values[i] = temp;
                    ListViewItem item = new ListViewItem();
                    item.Text = i.ToString();
                    item.SubItems.Add(values[i].ToString());
                    verilerListView.Items.Add(item);
                }
                
            }
            //Initializing data
            for (int i = 0; i < primeNumber; i++)
            {
               
                dataReisch[i] = new Data();
                binaryTreeData[i] = new DataBT();
            }
        }
        //Info function used for getting the performances of algorithms and 
        //Comparing them
        private void Info_Function()
        {
            int btProbe = 0, reischProbe = 0;
            for (int i = 0; i < primeNumber; i++)
            {
                btProbe += binaryTreeData[i].probe;
                reischProbe += dataReisch[i].probe;
            }
            infoText.Text = "Array Size = " + arraySize + " Prime Number = " + primeNumber;
            infoText.Text += "\nPacking factor = " + ((float)arraySize / primeNumber) + "\n";
            infoText.Text += "Binary Tree Probe = " + btProbe.ToString() + "\nAverage BT Probe = " + ((float)btProbe / arraySize);
            infoText.Text += "\nEISCH Probe = "+ reischProbe.ToString() + "\nAverage REISCH Probe = " + ((float)reischProbe/arraySize);

            infoText.Text += "\n" + (btProbe > reischProbe ? "Reisch better than Binary Tree" : "Binary Tree better than Reisch");
        }

        //Function to get a prime number that is also used in packing factor
        private void getPrimeKey()
        {

            bool prime = true;
            for (int i = arraySize + (arraySize/11) + 1; ; i++) {
                prime = true;
                
                for (int j = 2; j < i/2;j++) {
                    if (i % j == 0) 
                        prime = false;
                }
                if (prime)
                {
                    primeNumber = i;
                    break;
                }
            }
        }

        //Search button
        private void searchButton_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            Search_Func(int.Parse(searchTextBox.Text));
        }


        //Search function
        private void Search_Func(int value)
        {
            bool found = false;
            //Checking if value does exist in the array
            for (int i = 0; i < arraySize; i++)
            {
                if (values[i] == value)
                {
                    found = true;
                    break;
                }
            }
            //If not then return
            if (!found)
            {
                richTextBox.Text = "DOES NOT EXIST!";
                return;
            }
            //Initializing values
            binaryTreeSearchQueue = new Queue<int[]>();
            int key = Hash_Func(value);
            int temp = key;
            int[] tempArr = new int[2] { value, temp };
            binaryTreeSearchQueue.Enqueue(tempArr);

            //Reisch
            richTextBox.Text = "REISCH\n";
            while (dataReisch[temp].value != value) 
            {
                //Loop until the value is found
                richTextBox.Text += dataReisch[temp].value + " -> ";
                temp = dataReisch[temp].link;
                //Debug.WriteLine(temp + " " + dataReisch[temp].value);
                if (dataReisch[temp].value == value) 
                    break;
            }
            richTextBox.Text += dataReisch[temp].value + " Found in = " + temp;

            //Binary Tree
            richTextBox.Text += "\nBinary Tree\n";
            temp = key;
            //Looks until the value found
            while (binaryTreeData[temp].value != value)
            {
                richTextBox.Text += binaryTreeData[temp].value + " -> ";
                //Using the same method as assigning the value
                int left = (temp + I_Func(tempArr[0])) % primeNumber;
                int right = (temp + I_Func(binaryTreeData[temp].value)) % primeNumber;
                if (left == temp)
                    left = (left + left + 1) % primeNumber;
                if (right == temp)
                    right = (right + right + 2) % primeNumber;
                int[] leftArr = new int[2] { tempArr[0], left };
                int[] rightArr = new int[2] { tempArr[1], right };

                //Enqueueing for breadth first search
                binaryTreeSearchQueue.Enqueue(leftArr);
                binaryTreeSearchQueue.Enqueue(rightArr);
                tempArr = binaryTreeSearchQueue.Dequeue();
                temp = tempArr[1];
            }


            richTextBox.Text += binaryTreeData[temp].value + " Found in = " + temp;
        }


        private void REISCH_Algorithm()
        {
            
            for (int i = 0; i < arraySize; i++)
            {
                int key = Hash_Func(values[i]);
                //Assigning the value if the place is empty
                if (dataReisch[key].value == -1)
                {

                    dataReisch[key].value = values[i];
                    dataReisch[key].key = key;
                    dataReisch[key].probe = 1;
                }
                //Else add the value to the start of the chain
                else
                {

                    int tempLink = dataReisch[key].link;

                    //Look for empty place in the array randomly
                    random = new Random();
                    do
                    {
                        randomLocation = random.Next(0, arraySize);

                    }while (dataReisch[randomLocation].value != -1);

                    //Assign the main values link to the new node
                    //By doing this we add the new value to the start of the chain and after the root
                    dataReisch[key].link = randomLocation;
                    dataReisch[randomLocation].value = values[i];
                    dataReisch[randomLocation].link = tempLink;
                    dataReisch[randomLocation].probe = 2;

                    //Incrementing probe numbers if chain continues
                    while (true)
                    {
                        if (tempLink == -1)
                            break;
                        dataReisch[tempLink].probe += 1;
                        tempLink = dataReisch[tempLink].link;
                    }
                    
                }
            }
            //Loop that adds reisch values to the list view
            for (int i = 0; i < primeNumber; i++)
            {
                //Adding place, value, link and probe counts
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(dataReisch[i].value.ToString());
                item.SubItems.Add(dataReisch[i].link.ToString());
                item.SubItems.Add(dataReisch[i].probe == 0 ? "No Probe" : dataReisch[i].probe.ToString());
                reischListView.Items.Add(item);
            }
        }
        //Hash function                                                                         
        private int Hash_Func(int value)
        {
            return (value % primeNumber);
        }
        //Second hash function used in binary tree
        private int I_Func(int value)
        {           
            return (value / primeNumber) % primeNumber;
        }


        private void Binarytree_Hashing()
        {
            //Using the algorithm for every value in the array
            for (int i = 0; i < arraySize; i++)
            {
                int key = Hash_Func(values[i]);

                //If its empty then insert it
                if (binaryTreeData[key].value == -1)
                {                 
                    binaryTreeData[key].value = values[i];
                    binaryTreeData[key].probe = 1; //Save its probe count
                }
                else
                {
                    //Creating a queue to implement breadth first search 
                    nodeQueue = new Queue<QueueData>();
                    //Adding root of the binary tree
                    QueueData data = new QueueData();
                    data.keyPlace = key;
                    data.value = values[i];
                    data.mainValue = values[i];
                    //Function to find the empty place in the binary tree
                    CheckNode(data);

                }
            }
            //Looping to add the data to listView
            for (int i = 0; i < primeNumber; i++)
            {
                //Adding place, value and the probe number to the listview
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(binaryTreeData[i].value.ToString());
                item.SubItems.Add(binaryTreeData[i].probe == 0 ? "No Probe" : binaryTreeData[i].probe.ToString());
                btListView.Items.Add(item);

            }
        }

        //Recursive function that creates a binary tree and finds the empty place
        void CheckNode(QueueData data)
        {

            int temp = binaryTreeData[data.keyPlace].value;
            //Calculating left and right nodes 
            //data.value represents the upper value that comes to the node and used to calculate left node's place
            int left = (data.keyPlace + I_Func(data.value)) % primeNumber;
            //using root node's value as temp we calculate the right node's place
            int right = (data.keyPlace + I_Func(temp)) % primeNumber;
            
            //if left or right place is equals to the same spot change it to 2*i +1 or 2*i + 2
            //This is done to prevent looping in the binary tree
            if (left == data.keyPlace)
            {
                left = (left  +  left + 1) % primeNumber;               
            }

            if (right == data.keyPlace)
            {
                right = (right + right +  2) % primeNumber;              
            }
          
            //If left node is empty then we place it
            if (binaryTreeData[left].value == -1)
            {

                nodeQueue.Clear();
                binaryTreeData[left].value = data.mainValue;
                binaryTreeData[left].probe = data.probe + 2;
                
            }
            //If right node is empty
            else if (binaryTreeData[right].value == -1)
            {
                QueueData rightLeafs = data;
                //Loop to move the right side until its top of the place
                while (true)
                {
                    
                    //root of right side
                    if (rightLeafs.rightParent == null)
                    {
                        //Assign root with the value
                        binaryTreeData[rightLeafs.keyPlace].value = rightLeafs.mainValue;
                        binaryTreeData[rightLeafs.keyPlace].probe = data.probe + 1; //increment probe count
                        break;
                    }
                    //Move it down one by one until root is found
                    binaryTreeData[rightLeafs.keyPlace].value = rightLeafs.rightParent.value;
                    //Move one node up
                    rightLeafs = rightLeafs.rightParent;
                }
                //increment count
                binaryTreeData[rightLeafs.keyPlace].probe = data.probe + 1;
                //assign the bottom right
                binaryTreeData[right].value = temp;
                binaryTreeData[rightLeafs.keyPlace].value = rightLeafs.mainValue;
                //freeing memory
                nodeQueue.Clear();
            }
            else
            {
                //Adding one more probe to the count
                int probe = data.probe + 1;
                //Creating left and right nodes to 
                //be used in the queue
                QueueData leftData = new QueueData();
                leftData.keyPlace = left;
                leftData.value = data.value;
                leftData.mainValue = data.mainValue;
                leftData.probe = probe;
                QueueData rightData = new QueueData();
                //Saving this node as right node's parent
                //to be used in movement phase
                rightData.rightParent = data;
                rightData.keyPlace = right;
                rightData.value = temp;
                rightData.probe = probe;
                rightData.mainValue = data.mainValue;

                //Adding it to the queue
                nodeQueue.Enqueue(leftData);
                nodeQueue.Enqueue(rightData);
                //Using dequeue to implement the breadth first search
                CheckNode(nodeQueue.Dequeue());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clearing data from listviews
            verilerListView.Items.Clear();
            reischListView.Items.Clear();
            btListView.Items.Clear();
           // 
           //randomMax = Convert.ToInt32(textMax.Text);

            Inputs();

            REISCH_Algorithm();
            Binarytree_Hashing();
            Info_Function();
        }



        private void Inputs()
        {

            //Creating array for main values
            

            string[] lines = InputsLB.Lines;
            values = new int[lines.Length];
            arraySize = lines.Length;

            getPrimeKey();

            dataReisch = new Data[primeNumber];
            binaryTreeData = new DataBT[primeNumber];
            for (int i = 0; i < lines.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                values[i] = Convert.ToInt32(lines[i]);
                item.Text = i.ToString();
                item.SubItems.Add(values[i].ToString());
                verilerListView.Items.Add(item);
                Debug.WriteLine(values[i]);
            }



            for (int i = 0; i < primeNumber; i++)
            {

                dataReisch[i] = new Data();
                binaryTreeData[i] = new DataBT();
            }
        }
    }
}
