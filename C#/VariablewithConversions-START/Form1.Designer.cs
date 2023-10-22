namespace VariablewithConversions
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
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnBirthday = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewAge = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(163, 35);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(156, 29);
            this.txtAge.TabIndex = 0;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBirthday
            // 
            this.btnBirthday.Location = new System.Drawing.Point(12, 156);
            this.btnBirthday.Name = "btnBirthday";
            this.btnBirthday.Size = new System.Drawing.Size(121, 59);
            this.btnBirthday.TabIndex = 1;
            this.btnBirthday.Text = "&Birthday";
            this.btnBirthday.UseVisualStyleBackColor = true;
            this.btnBirthday.Click += new System.EventHandler(this.btnBirthday_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Age:";
            // 
            // lblNewAge
            // 
            this.lblNewAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewAge.Location = new System.Drawing.Point(163, 91);
            this.lblNewAge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNewAge.Name = "lblNewAge";
            this.lblNewAge.Size = new System.Drawing.Size(156, 34);
            this.lblNewAge.TabIndex = 4;
            this.lblNewAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(198, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 59);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 227);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNewAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBirthday);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variable with Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNewAge;
        private System.Windows.Forms.Button btnClear;
    }
}

