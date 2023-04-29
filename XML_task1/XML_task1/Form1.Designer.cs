namespace XML_task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            propertyGrid1 = new PropertyGrid();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // propertyGrid1
            // 
            propertyGrid1.HelpVisible = false;
            propertyGrid1.Location = new Point(12, 186);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(320, 221);
            propertyGrid1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(320, 154);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 419);
            Controls.Add(listBox1);
            Controls.Add(propertyGrid1);
            Name = "Form1";
            Text = "Xml Reader";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid propertyGrid1;
        private ListBox listBox1;
    }
}