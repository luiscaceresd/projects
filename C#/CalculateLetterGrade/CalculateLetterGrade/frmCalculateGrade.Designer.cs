namespace CalculateLetterGrade
{
    partial class frmCalculateGrade
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
            this.txtNumberGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDean = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblLetter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.chkBonus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Number grade:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberGrade
            // 
            this.txtNumberGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberGrade.Location = new System.Drawing.Point(153, 10);
            this.txtNumberGrade.Name = "txtNumberGrade";
            this.txtNumberGrade.Size = new System.Drawing.Size(50, 26);
            this.txtNumberGrade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Letter grade:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(6, 121);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(109, 37);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(242, 121);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDean
            // 
            this.lblDean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDean.Location = new System.Drawing.Point(222, 9);
            this.lblDean.Name = "lblDean";
            this.lblDean.Size = new System.Drawing.Size(181, 28);
            this.lblDean.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(124, 121);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 37);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblLetter
            // 
            this.lblLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter.Location = new System.Drawing.Point(153, 49);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(50, 23);
            this.lblLetter.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Outcome:";
            // 
            // lblOutcome
            // 
            this.lblOutcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(153, 81);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(100, 23);
            this.lblOutcome.TabIndex = 10;
            // 
            // chkBonus
            // 
            this.chkBonus.AutoSize = true;
            this.chkBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBonus.Location = new System.Drawing.Point(282, 50);
            this.chkBonus.Name = "chkBonus";
            this.chkBonus.Size = new System.Drawing.Size(75, 22);
            this.chkBonus.TabIndex = 11;
            this.chkBonus.Text = "Bonus";
            this.chkBonus.UseVisualStyleBackColor = true;
            this.chkBonus.CheckedChanged += new System.EventHandler(this.chkBonus_CheckedChanged);
            // 
            // frmCalculateGrade
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(430, 170);
            this.Controls.Add(this.chkBonus);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDean);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberGrade);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculateGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDean;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.CheckBox chkBonus;
    }
}

