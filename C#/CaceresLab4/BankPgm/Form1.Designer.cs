namespace BankPgm
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.chkBankFee = new System.Windows.Forms.CheckBox();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.radDeposit = new System.Windows.Forms.RadioButton();
            this.grpTxn = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatement = new System.Windows.Forms.Label();
            this.grpSelect.SuspendLayout();
            this.grpTxn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGreeting.Location = new System.Drawing.Point(5, 10);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(58, 22);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(211, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Balance:";
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.chkBankFee);
            this.grpSelect.Controls.Add(this.radWithdraw);
            this.grpSelect.Controls.Add(this.radDeposit);
            this.grpSelect.Location = new System.Drawing.Point(6, 44);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(159, 234);
            this.grpSelect.TabIndex = 2;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Select [ALT] +";
            // 
            // chkBankFee
            // 
            this.chkBankFee.AutoSize = true;
            this.chkBankFee.Location = new System.Drawing.Point(7, 191);
            this.chkBankFee.Name = "chkBankFee";
            this.chkBankFee.Size = new System.Drawing.Size(101, 26);
            this.chkBankFee.TabIndex = 2;
            this.chkBankFee.Text = "&Bank Fee";
            this.chkBankFee.UseVisualStyleBackColor = true;
            this.chkBankFee.CheckedChanged += new System.EventHandler(this.chkBankFee_CheckedChanged);
            // 
            // radWithdraw
            // 
            this.radWithdraw.AutoSize = true;
            this.radWithdraw.Location = new System.Drawing.Point(7, 112);
            this.radWithdraw.Name = "radWithdraw";
            this.radWithdraw.Size = new System.Drawing.Size(108, 26);
            this.radWithdraw.TabIndex = 1;
            this.radWithdraw.TabStop = true;
            this.radWithdraw.Text = "&Withdraw";
            this.radWithdraw.UseVisualStyleBackColor = true;
            this.radWithdraw.CheckedChanged += new System.EventHandler(this.radWithdraw_CheckedChanged);
            // 
            // radDeposit
            // 
            this.radDeposit.AutoSize = true;
            this.radDeposit.Location = new System.Drawing.Point(7, 33);
            this.radDeposit.Name = "radDeposit";
            this.radDeposit.Size = new System.Drawing.Size(92, 26);
            this.radDeposit.TabIndex = 0;
            this.radDeposit.TabStop = true;
            this.radDeposit.Text = "&Deposit";
            this.radDeposit.UseVisualStyleBackColor = true;
            this.radDeposit.CheckedChanged += new System.EventHandler(this.radDeposit_CheckedChanged);
            // 
            // grpTxn
            // 
            this.grpTxn.Controls.Add(this.btnCancel);
            this.grpTxn.Controls.Add(this.btnSave);
            this.grpTxn.Controls.Add(this.txtAmount);
            this.grpTxn.Controls.Add(this.label1);
            this.grpTxn.Location = new System.Drawing.Point(178, 44);
            this.grpTxn.Name = "grpTxn";
            this.grpTxn.Size = new System.Drawing.Size(248, 234);
            this.grpTxn.TabIndex = 0;
            this.grpTxn.TabStop = false;
            this.grpTxn.Text = "grpTxn";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(130, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 72);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 72);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(130, 32);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(110, 29);
            this.txtAmount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount:";
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Location = new System.Drawing.Point(300, 10);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(126, 22);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Statement:";
            // 
            // lblStatement
            // 
            this.lblStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblStatement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatement.Location = new System.Drawing.Point(437, 31);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(312, 247);
            this.lblStatement.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 284);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.grpTxn);
            this.Controls.Add(this.grpSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGreeting);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Program by";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            this.grpTxn.ResumeLayout(false);
            this.grpTxn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.RadioButton radDeposit;
        private System.Windows.Forms.GroupBox grpTxn;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.CheckBox chkBankFee;
        private System.Windows.Forms.Label lblStatement;
    }
}

