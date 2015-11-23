namespace WordSearchGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lstWordsInGrid = new System.Windows.Forms.ListBox();
            this.wordSearch1 = new WordSearchGenerator.WordSearch();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(26, 246);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(250, 354);
            this.listBox1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 79);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(254, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 31);
            this.textBox1.TabIndex = 2;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(26, 190);
            this.btnGen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(254, 44);
            this.btnGen.TabIndex = 5;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(26, 135);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(254, 44);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lstWordsInGrid
            // 
            this.lstWordsInGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstWordsInGrid.FormattingEnabled = true;
            this.lstWordsInGrid.ItemHeight = 25;
            this.lstWordsInGrid.Location = new System.Drawing.Point(26, 648);
            this.lstWordsInGrid.Margin = new System.Windows.Forms.Padding(6);
            this.lstWordsInGrid.Name = "lstWordsInGrid";
            this.lstWordsInGrid.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstWordsInGrid.Size = new System.Drawing.Size(250, 229);
            this.lstWordsInGrid.TabIndex = 9;
            // 
            // wordSearch1
            // 
            this.wordSearch1.BackColor = System.Drawing.Color.White;
            this.wordSearch1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wordSearch1.Location = new System.Drawing.Point(298, 29);
            this.wordSearch1.Margin = new System.Windows.Forms.Padding(12);
            this.wordSearch1.Name = "wordSearch1";
            this.wordSearch1.Size = new System.Drawing.Size(1424, 923);
            this.wordSearch1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2131, 976);
            this.Controls.Add(this.lstWordsInGrid);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.wordSearch1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "WordSearchgenerator";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private WordSearch wordSearch1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lstWordsInGrid;
    }
}

