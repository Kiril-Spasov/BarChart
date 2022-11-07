namespace BarChart
{
    partial class FormBarChart
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
            this.BtnHorizontal = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnVertical = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnHorizontal
            // 
            this.BtnHorizontal.Location = new System.Drawing.Point(51, 499);
            this.BtnHorizontal.Name = "BtnHorizontal";
            this.BtnHorizontal.Size = new System.Drawing.Size(156, 58);
            this.BtnHorizontal.TabIndex = 0;
            this.BtnHorizontal.Text = "Horizontal";
            this.BtnHorizontal.UseVisualStyleBackColor = true;
            this.BtnHorizontal.Click += new System.EventHandler(this.BtnHorizontal_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(244, 499);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(147, 58);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnVertical
            // 
            this.BtnVertical.Location = new System.Drawing.Point(436, 499);
            this.BtnVertical.Name = "BtnVertical";
            this.BtnVertical.Size = new System.Drawing.Size(178, 58);
            this.BtnVertical.TabIndex = 2;
            this.BtnVertical.Text = "Vertical";
            this.BtnVertical.UseVisualStyleBackColor = true;
            this.BtnVertical.Click += new System.EventHandler(this.BtnVertical_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(51, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 462);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormBarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnVertical);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnHorizontal);
            this.Name = "FormBarChart";
            this.Text = "Bar Chart";
            this.Load += new System.EventHandler(this.FormBarChart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHorizontal;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnVertical;
        private System.Windows.Forms.Panel panel1;
    }
}

