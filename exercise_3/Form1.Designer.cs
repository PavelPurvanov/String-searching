namespace exercise_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button2_search = new System.Windows.Forms.Button();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTiming = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(673, 395);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1_Clear
            // 
            this.button1_Clear.Location = new System.Drawing.Point(197, 452);
            this.button1_Clear.Name = "button1_Clear";
            this.button1_Clear.Size = new System.Drawing.Size(108, 23);
            this.button1_Clear.TabIndex = 1;
            this.button1_Clear.Text = "Clear";
            this.button1_Clear.UseVisualStyleBackColor = true;
            this.button1_Clear.Click += new System.EventHandler(this.button1_Clear_Click_1);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Word for searching";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(311, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time for searching";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(311, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Finded words";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 452);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(184, 23);
            this.searchBox.TabIndex = 5;
            // 
            // button2_search
            // 
            this.button2_search.Location = new System.Drawing.Point(197, 425);
            this.button2_search.Name = "button2_search";
            this.button2_search.Size = new System.Drawing.Size(108, 23);
            this.button2_search.TabIndex = 6;
            this.button2_search.Text = "Search";
            this.button2_search.UseVisualStyleBackColor = true;
            this.button2_search.Click += new System.EventHandler(this.button2_search_Click);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(693, 39);
            this.textBoxPosition.Multiline = true;
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPosition.Size = new System.Drawing.Size(118, 436);
            this.textBoxPosition.TabIndex = 8;
            this.textBoxPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(693, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Position";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTiming
            // 
            this.labelTiming.BackColor = System.Drawing.Color.White;
            this.labelTiming.Location = new System.Drawing.Point(414, 426);
            this.labelTiming.Name = "labelTiming";
            this.labelTiming.Size = new System.Drawing.Size(94, 23);
            this.labelTiming.TabIndex = 11;
            // 
            // labelCounter
            // 
            this.labelCounter.BackColor = System.Drawing.Color.White;
            this.labelCounter.Location = new System.Drawing.Point(414, 452);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(94, 23);
            this.labelCounter.TabIndex = 12;
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 479);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.labelTiming);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.button2_search);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_Clear);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Павел Диянов Първанов ф.н.17621736 СИТ Курс: 3 Група: 2Б";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button2_search;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTiming;
        private System.Windows.Forms.Label labelCounter;
    }
}

