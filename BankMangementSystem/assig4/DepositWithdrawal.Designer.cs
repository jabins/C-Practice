namespace assig4
{
    partial class DepositWithdrawal
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.withdrawalBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deposit : $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Withdrawal : $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Balance : $";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(100, 51);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(0, 13);
            this.accountLabel.TabIndex = 5;
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(94, 141);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(217, 20);
            this.depositBox.TabIndex = 7;
            // 
            // withdrawalBox
            // 
            this.withdrawalBox.Location = new System.Drawing.Point(111, 178);
            this.withdrawalBox.Name = "withdrawalBox";
            this.withdrawalBox.Size = new System.Drawing.Size(200, 20);
            this.withdrawalBox.TabIndex = 8;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(98, 221);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(13, 13);
            this.balanceLabel.TabIndex = 9;
            this.balanceLabel.Text = "0";
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(317, 139);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(113, 23);
            this.depositBtn.TabIndex = 10;
            this.depositBtn.Text = "DEPOSIT";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawalBtn
            // 
            this.withdrawalBtn.Location = new System.Drawing.Point(317, 176);
            this.withdrawalBtn.Name = "withdrawalBtn";
            this.withdrawalBtn.Size = new System.Drawing.Size(113, 23);
            this.withdrawalBtn.TabIndex = 11;
            this.withdrawalBtn.Text = "WITHDRAWAL";
            this.withdrawalBtn.UseVisualStyleBackColor = true;
            this.withdrawalBtn.Click += new System.EventHandler(this.withdrawalBtn_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 292);
            this.Controls.Add(this.withdrawalBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.withdrawalBox);
            this.Controls.Add(this.depositBox);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Transaction Information";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label accountLabel;
        public System.Windows.Forms.TextBox depositBox;
        public System.Windows.Forms.TextBox withdrawalBox;
        public System.Windows.Forms.Label balanceLabel;
        public System.Windows.Forms.Button depositBtn;
        public System.Windows.Forms.Button withdrawalBtn;
    }
}