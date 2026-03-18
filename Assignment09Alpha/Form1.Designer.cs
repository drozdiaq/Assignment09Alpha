namespace Assignment09Alpha
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
            this.clbCondiments = new System.Windows.Forms.CheckedListBox();
            this.cmbBread = new System.Windows.Forms.ComboBox();
            this.cmbFillings = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbCondiments
            // 
            this.clbCondiments.CheckOnClick = true;
            this.clbCondiments.FormattingEnabled = true;
            this.clbCondiments.Location = new System.Drawing.Point(746, 135);
            this.clbCondiments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbCondiments.Name = "clbCondiments";
            this.clbCondiments.Size = new System.Drawing.Size(354, 326);
            this.clbCondiments.TabIndex = 0;
            // 
            // cmbBread
            // 
            this.cmbBread.FormattingEnabled = true;
            this.cmbBread.Location = new System.Drawing.Point(108, 135);
            this.cmbBread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBread.Name = "cmbBread";
            this.cmbBread.Size = new System.Drawing.Size(251, 28);
            this.cmbBread.TabIndex = 1;
            // 
            // cmbFillings
            // 
            this.cmbFillings.FormattingEnabled = true;
            this.cmbFillings.Location = new System.Drawing.Point(398, 135);
            this.cmbFillings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFillings.Name = "cmbFillings";
            this.cmbFillings.Size = new System.Drawing.Size(258, 28);
            this.cmbFillings.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(298, 572);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(112, 35);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "button1";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(774, 572);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "button2";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1014, 469);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFillings);
            this.Controls.Add(this.cmbBread);
            this.Controls.Add(this.clbCondiments);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbCondiments;
        private System.Windows.Forms.ComboBox cmbBread;
        private System.Windows.Forms.ComboBox cmbFillings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

