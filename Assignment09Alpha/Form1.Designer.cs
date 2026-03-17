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
            this.SuspendLayout();
            // 
            // clbCondiments
            // 
            this.clbCondiments.FormattingEnabled = true;
            this.clbCondiments.Items.AddRange(new object[] {
            "Bacon (2 strips)",
            "Buffalo Sauce",
            "Chipotle Southwest Sauce",
            "Guacamole",
            "Honey Mustard Sauce, Fat Free",
            "Light Mayonnaise (1 T)",
            "Mayonnaise (1 T)",
            "Mustard yellow or deli brown (2 tsp.)",
            "Olive Oil Blend (1 tsp.)",
            "Pepperoni, 3 slices",
            "Ranch Dressing",
            "Sweet Onion Sauce, Fat Free",
            "Vinaigrette",
            "Vinegar (1 tsp.)"});
            this.clbCondiments.Location = new System.Drawing.Point(464, 88);
            this.clbCondiments.Name = "clbCondiments";
            this.clbCondiments.Size = new System.Drawing.Size(208, 214);
            this.clbCondiments.TabIndex = 0;
            // 
            // cmbBread
            // 
            this.cmbBread.FormattingEnabled = true;
            this.cmbBread.Location = new System.Drawing.Point(72, 88);
            this.cmbBread.Name = "cmbBread";
            this.cmbBread.Size = new System.Drawing.Size(121, 21);
            this.cmbBread.TabIndex = 1;
            // 
            // cmbFillings
            // 
            this.cmbFillings.FormattingEnabled = true;
            this.cmbFillings.Location = new System.Drawing.Point(265, 88);
            this.cmbFillings.Name = "cmbFillings";
            this.cmbFillings.Size = new System.Drawing.Size(121, 21);
            this.cmbFillings.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(199, 372);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "button1";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(516, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "button2";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFillings);
            this.Controls.Add(this.cmbBread);
            this.Controls.Add(this.clbCondiments);
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
    }
}

