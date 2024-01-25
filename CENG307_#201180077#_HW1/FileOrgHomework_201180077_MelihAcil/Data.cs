using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CENG307_201180077_HW1
{
    internal class Data
    {
        //Data class used in Reisch algorithm 
        //It also holds links and probe counts
        public int key;
        public int value;
        public int link;
        public int probe;

        //Constructor used to assign initial values
        public Data()
        {
            value = -1;
            key = 0;
            link = -1;
            probe = 0;
        }
    }
}
