namespace CaceresDuranLab3
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
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMortgage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picHouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal:";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(89, 11);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(100, 27);
            this.txtPrincipal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate:";
            // 
            // lblRate
            // 
            this.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRate.Location = new System.Drawing.Point(89, 62);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(100, 21);
            this.lblRate.TabIndex = 3;
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Years:";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(89, 107);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 27);
            this.txtYears.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monthly Mortgage:";
            // 
            // lblMortgage
            // 
            this.lblMortgage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMortgage.Location = new System.Drawing.Point(158, 157);
            this.lblMortgage.Name = "lblMortgage";
            this.lblMortgage.Size = new System.Drawing.Size(100, 27);
            this.lblMortgage.TabIndex = 7;
            this.lblMortgage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(17, 207);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 50);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(123, 207);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(229, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picHouse
            // 
            this.picHouse.Image = global::CaceresDuranLab3.Properties.Resources.houseImage;
            this.picHouse.Location = new System.Drawing.Point(369, 36);
            this.picHouse.Name = "picHouse";
            this.picHouse.Size = new System.Drawing.Size(183, 192);
            this.picHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHouse.TabIndex = 8;
            this.picHouse.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(564, 271);
            this.Controls.Add(this.picHouse);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMortgage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mortgage Calculator by Luis Caceres";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMortgage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picHouse;
    }
}

