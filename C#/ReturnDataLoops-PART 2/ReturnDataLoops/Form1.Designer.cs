namespace ReturnDataLoops
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.btnRunLoop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFive = new System.Windows.Forms.RadioButton();
            this.radTwo = new System.Windows.Forms.RadioButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDemo = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message";
            // 
            // lblSum
            // 
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSum.Location = new System.Drawing.Point(165, 93);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(133, 30);
            this.lblSum.TabIndex = 3;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(165, 27);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(133, 26);
            this.txtStart.TabIndex = 0;
            // 
            // btnRunLoop
            // 
            this.btnRunLoop.Location = new System.Drawing.Point(194, 228);
            this.btnRunLoop.Name = "btnRunLoop";
            this.btnRunLoop.Size = new System.Drawing.Size(114, 59);
            this.btnRunLoop.TabIndex = 2;
            this.btnRunLoop.Text = "&Run Loop";
            this.btnRunLoop.UseVisualStyleBackColor = true;
            this.btnRunLoop.Click += new System.EventHandler(this.btnRunLoop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(335, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 59);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFive);
            this.groupBox1.Controls.Add(this.radTwo);
            this.groupBox1.Location = new System.Drawing.Point(324, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jump by";
            // 
            // radFive
            // 
            this.radFive.AutoSize = true;
            this.radFive.Location = new System.Drawing.Point(18, 81);
            this.radFive.Name = "radFive";
            this.radFive.Size = new System.Drawing.Size(60, 24);
            this.radFive.TabIndex = 1;
            this.radFive.TabStop = true;
            this.radFive.Text = "Five";
            this.radFive.UseVisualStyleBackColor = true;
            // 
            // radTwo
            // 
            this.radTwo.AutoSize = true;
            this.radTwo.Location = new System.Drawing.Point(18, 44);
            this.radTwo.Name = "radTwo";
            this.radTwo.Size = new System.Drawing.Size(59, 24);
            this.radTwo.TabIndex = 0;
            this.radTwo.TabStop = true;
            this.radTwo.Text = "Two";
            this.radTwo.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(165, 159);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(133, 30);
            this.lblMessage.TabIndex = 10;
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(42, 228);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(114, 59);
            this.btnDemo.TabIndex = 1;
            this.btnDemo.Text = "&Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 20;
            this.lstNumbers.Items.AddRange(new object[] {
            "Demo listbox"});
            this.lstNumbers.Location = new System.Drawing.Point(455, 27);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(207, 284);
            this.lstNumbers.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 323);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRunLoop);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Ftns and Loops";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Button btnRunLoop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFive;
        private System.Windows.Forms.RadioButton radTwo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.ListBox lstNumbers;
    }
}

