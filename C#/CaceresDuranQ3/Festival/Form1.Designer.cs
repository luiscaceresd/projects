
namespace Festival
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartingNumber = new System.Windows.Forms.TextBox();
            this.lblFirstCalculation = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSecondCalculation = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picCollege = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCollege)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Calculation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second Calculation:";
            // 
            // txtStartingNumber
            // 
            this.txtStartingNumber.Location = new System.Drawing.Point(230, 22);
            this.txtStartingNumber.Name = "txtStartingNumber";
            this.txtStartingNumber.Size = new System.Drawing.Size(100, 23);
            this.txtStartingNumber.TabIndex = 0;
            // 
            // lblFirstCalculation
            // 
            this.lblFirstCalculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstCalculation.Location = new System.Drawing.Point(230, 80);
            this.lblFirstCalculation.Name = "lblFirstCalculation";
            this.lblFirstCalculation.Size = new System.Drawing.Size(100, 23);
            this.lblFirstCalculation.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 209);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 45);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSecondCalculation
            // 
            this.lblSecondCalculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondCalculation.Location = new System.Drawing.Point(230, 134);
            this.lblSecondCalculation.Name = "lblSecondCalculation";
            this.lblSecondCalculation.Size = new System.Drawing.Size(100, 23);
            this.lblSecondCalculation.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(142, 209);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(256, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picCollege
            // 
            this.picCollege.Image = ((System.Drawing.Image)(resources.GetObject("picCollege.Image")));
            this.picCollege.Location = new System.Drawing.Point(386, 22);
            this.picCollege.Name = "picCollege";
            this.picCollege.Size = new System.Drawing.Size(225, 232);
            this.picCollege.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCollege.TabIndex = 7;
            this.picCollege.TabStop = false;
            this.picCollege.Click += new System.EventHandler(this.picCollege_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(644, 288);
            this.Controls.Add(this.picCollege);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblSecondCalculation);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFirstCalculation);
            this.Controls.Add(this.txtStartingNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Festival by Luis Caceres";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCollege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartingNumber;
        private System.Windows.Forms.Label lblFirstCalculation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSecondCalculation;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picCollege;
    }
}

