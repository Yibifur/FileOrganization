namespace CENG307_201180077_HW1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.verilerListView = new System.Windows.Forms.ListView();
            this.valueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.keyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textMax = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reischListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.randomArrSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputsLB = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verilerListView
            // 
            this.verilerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.valueCol,
            this.keyCol});
            this.verilerListView.HideSelection = false;
            this.verilerListView.Location = new System.Drawing.Point(646, 89);
            this.verilerListView.Name = "verilerListView";
            this.verilerListView.Size = new System.Drawing.Size(142, 471);
            this.verilerListView.TabIndex = 1;
            this.verilerListView.UseCompatibleStateImageBehavior = false;
            this.verilerListView.View = System.Windows.Forms.View.Details;
            // 
            // valueCol
            // 
            this.valueCol.Text = "ID";
            // 
            // keyCol
            // 
            this.keyCol.Text = "Value";
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(408, 27);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(45, 20);
            this.textMax.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reischListView
            // 
            this.reischListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.reischListView.HideSelection = false;
            this.reischListView.Location = new System.Drawing.Point(806, 89);
            this.reischListView.Name = "reischListView";
            this.reischListView.Size = new System.Drawing.Size(267, 471);
            this.reischListView.TabIndex = 4;
            this.reischListView.UseCompatibleStateImageBehavior = false;
            this.reischListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Link";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Probe";
            // 
            // randomArrSize
            // 
            this.randomArrSize.Location = new System.Drawing.Point(563, 27);
            this.randomArrSize.Name = "randomArrSize";
            this.randomArrSize.Size = new System.Drawing.Size(50, 20);
            this.randomArrSize.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Value Range 0-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Array Size";
            // 
            // btListView
            // 
            this.btListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.btListView.HideSelection = false;
            this.btListView.Location = new System.Drawing.Point(1099, 89);
            this.btListView.Name = "btListView";
            this.btListView.Size = new System.Drawing.Size(267, 471);
            this.btListView.TabIndex = 9;
            this.btListView.UseCompatibleStateImageBehavior = false;
            this.btListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Key";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Probe";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(379, 269);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(115, 20);
            this.searchTextBox.TabIndex = 10;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(379, 135);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(234, 100);
            this.richTextBox.TabIndex = 11;
            this.richTextBox.Text = "";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(501, 265);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 24);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoText
            // 
            this.infoText.Location = new System.Drawing.Point(379, 314);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(234, 100);
            this.infoText.TabIndex = 13;
            this.infoText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(685, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Values";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(906, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "REISCH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(1189, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Binary Tree";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(826, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Melih Açıl 201180077 CENG 307 HW1";
            // 
            // InputsLB
            // 
            this.InputsLB.Location = new System.Drawing.Point(61, 12);
            this.InputsLB.Name = "InputsLB";
            this.InputsLB.Size = new System.Drawing.Size(222, 548);
            this.InputsLB.TabIndex = 18;
            this.InputsLB.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1394, 676);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InputsLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.btListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomArrSize);
            this.Controls.Add(this.reischListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.verilerListView);
            this.Name = "Form1";
            this.Text = "CENG 307 HW_1 Melih Acil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView verilerListView;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader valueCol;
        private System.Windows.Forms.ColumnHeader keyCol;
        private System.Windows.Forms.ListView reischListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox randomArrSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView btListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox infoText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RichTextBox InputsLB;
        private System.Windows.Forms.Button button2;
    }
}

