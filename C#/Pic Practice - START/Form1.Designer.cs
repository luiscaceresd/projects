namespace Pic_Practice
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
            this.btnText = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.picCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(38, 324);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(136, 69);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "&Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(524, 324);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 69);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(281, 324);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(136, 69);
            this.btnPicture.TabIndex = 1;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // lblText
            // 
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText.Location = new System.Drawing.Point(26, 27);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(634, 270);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "This is a sentence.\r\n\r\nAnother line.\r\n";
            this.lblText.Visible = false;
            // 
            // picCat
            // 
            this.picCat.Image = ((System.Drawing.Image)(resources.GetObject("picCat.Image")));
            this.picCat.Location = new System.Drawing.Point(26, 27);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(634, 270);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCat.TabIndex = 4;
            this.picCat.TabStop = false;
            this.picCat.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(693, 438);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.picCat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice";
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox picCat;
    }
}

