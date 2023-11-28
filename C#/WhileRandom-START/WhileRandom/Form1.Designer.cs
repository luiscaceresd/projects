namespace WhileRandom
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
            this.nudHowMany = new System.Windows.Forms.NumericUpDown();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHowMany)).BeginInit();
            this.SuspendLayout();
            // 
            // nudHowMany
            // 
            this.nudHowMany.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHowMany.Location = new System.Drawing.Point(30, 28);
            this.nudHowMany.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudHowMany.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHowMany.Name = "nudHowMany";
            this.nudHowMany.Size = new System.Drawing.Size(120, 26);
            this.nudHowMany.TabIndex = 0;
            this.nudHowMany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHowMany.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHowMany.ValueChanged += new System.EventHandler(this.nudHowMany_ValueChanged);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 20;
            this.lstNumbers.Location = new System.Drawing.Point(331, 28);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(181, 304);
            this.lstNumbers.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Location = new System.Drawing.Point(30, 104);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(282, 228);
            this.lblInfo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 367);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.nudHowMany);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.nudHowMany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudHowMany;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblInfo;
    }
}

