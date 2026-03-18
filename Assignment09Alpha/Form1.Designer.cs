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
            this.lblSlogan = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbCondiments
            // 
            this.clbCondiments.CheckOnClick = true;
            this.clbCondiments.FormattingEnabled = true;
            this.clbCondiments.Location = new System.Drawing.Point(733, 135);
            this.clbCondiments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbCondiments.Name = "clbCondiments";
            this.clbCondiments.Size = new System.Drawing.Size(354, 349);
            this.clbCondiments.TabIndex = 2;
            // 
            // cmbBread
            // 
            this.cmbBread.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBread.FormattingEnabled = true;
            this.cmbBread.Location = new System.Drawing.Point(49, 135);
            this.cmbBread.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBread.MaxDropDownItems = 16;
            this.cmbBread.Name = "cmbBread";
            this.cmbBread.Size = new System.Drawing.Size(310, 28);
            this.cmbBread.TabIndex = 0;
            // 
            // cmbFillings
            // 
            this.cmbFillings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFillings.FormattingEnabled = true;
            this.cmbFillings.Location = new System.Drawing.Point(398, 135);
            this.cmbFillings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFillings.MaxDropDownItems = 16;
            this.cmbFillings.Name = "cmbFillings";
            this.cmbFillings.Size = new System.Drawing.Size(258, 28);
            this.cmbFillings.TabIndex = 1;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Location = new System.Drawing.Point(549, 14);
            this.lblSlogan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(51, 20);
            this.lblSlogan.TabIndex = 3;
            this.lblSlogan.Text = "label1";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(75, 499);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(200, 35);
            this.btnSum.TabIndex = 4;
            this.btnSum.TabStop = false;
            this.btnSum.Text = "&Summarize order";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(471, 499);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(990, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSum;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1125, 643);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.cmbFillings);
            this.Controls.Add(this.cmbBread);
            this.Controls.Add(this.clbCondiments);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1147, 699);
            this.MinimumSize = new System.Drawing.Size(1147, 699);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 09 - Alpha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbCondiments;
        private System.Windows.Forms.ComboBox cmbBread;
        private System.Windows.Forms.ComboBox cmbFillings;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

