namespace Trace
{
    partial class frmTrace
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.chkFlip = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnHuh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "txtInput";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(6, 37);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 23);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "lblOutput";
            // 
            // chkFlip
            // 
            this.chkFlip.AutoSize = true;
            this.chkFlip.Location = new System.Drawing.Point(6, 72);
            this.chkFlip.Name = "chkFlip";
            this.chkFlip.Size = new System.Drawing.Size(49, 20);
            this.chkFlip.TabIndex = 2;
            this.chkFlip.Text = "Flip";
            this.chkFlip.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(61, 72);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(12, 98);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(195, 154);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "lblDisplay";
            // 
            // btnHuh
            // 
            this.btnHuh.Location = new System.Drawing.Point(143, 72);
            this.btnHuh.Name = "btnHuh";
            this.btnHuh.Size = new System.Drawing.Size(75, 23);
            this.btnHuh.TabIndex = 5;
            this.btnHuh.Text = "&Huh";
            this.btnHuh.UseVisualStyleBackColor = true;
            this.btnHuh.Click += new System.EventHandler(this.btnHuh_Click);
            // 
            // frmTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 261);
            this.Controls.Add(this.btnHuh);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.chkFlip);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "frmTrace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trace";
            this.Load += new System.EventHandler(this.frmTrace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.CheckBox chkFlip;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnHuh;
    }
}

