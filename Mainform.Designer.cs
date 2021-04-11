namespace TerminalApp
{
	partial class Mainform
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
			this.lnklbl_profit = new System.Windows.Forms.LinkLabel();
			this.lnklbl_expense = new System.Windows.Forms.LinkLabel();
			this.lnklbl_providers = new System.Windows.Forms.LinkLabel();
			this.lnklbl_payto = new System.Windows.Forms.LinkLabel();
			this.lnklbl_account_confing = new System.Windows.Forms.LinkLabel();
			this.lbl_welcome = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lnklbl_profit
			// 
			this.lnklbl_profit.AutoSize = true;
			this.lnklbl_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lnklbl_profit.Location = new System.Drawing.Point(31, 39);
			this.lnklbl_profit.Name = "lnklbl_profit";
			this.lnklbl_profit.Size = new System.Drawing.Size(113, 24);
			this.lnklbl_profit.TabIndex = 0;
			this.lnklbl_profit.TabStop = true;
			this.lnklbl_profit.Text = "Profit History";
			// 
			// lnklbl_expense
			// 
			this.lnklbl_expense.AutoSize = true;
			this.lnklbl_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lnklbl_expense.Location = new System.Drawing.Point(31, 99);
			this.lnklbl_expense.Name = "lnklbl_expense";
			this.lnklbl_expense.Size = new System.Drawing.Size(148, 24);
			this.lnklbl_expense.TabIndex = 1;
			this.lnklbl_expense.TabStop = true;
			this.lnklbl_expense.Text = "Expense History\r\n";
			// 
			// lnklbl_providers
			// 
			this.lnklbl_providers.AutoSize = true;
			this.lnklbl_providers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lnklbl_providers.Location = new System.Drawing.Point(31, 160);
			this.lnklbl_providers.Name = "lnklbl_providers";
			this.lnklbl_providers.Size = new System.Drawing.Size(89, 24);
			this.lnklbl_providers.TabIndex = 2;
			this.lnklbl_providers.TabStop = true;
			this.lnklbl_providers.Text = "Providers\r\n";
			this.lnklbl_providers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// lnklbl_payto
			// 
			this.lnklbl_payto.AutoSize = true;
			this.lnklbl_payto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lnklbl_payto.Location = new System.Drawing.Point(31, 226);
			this.lnklbl_payto.Name = "lnklbl_payto";
			this.lnklbl_payto.Size = new System.Drawing.Size(61, 24);
			this.lnklbl_payto.TabIndex = 3;
			this.lnklbl_payto.TabStop = true;
			this.lnklbl_payto.Text = "Pay to";
			// 
			// lnklbl_account_confing
			// 
			this.lnklbl_account_confing.AutoSize = true;
			this.lnklbl_account_confing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lnklbl_account_confing.Location = new System.Drawing.Point(31, 287);
			this.lnklbl_account_confing.Name = "lnklbl_account_confing";
			this.lnklbl_account_confing.Size = new System.Drawing.Size(139, 24);
			this.lnklbl_account_confing.TabIndex = 4;
			this.lnklbl_account_confing.TabStop = true;
			this.lnklbl_account_confing.Text = "Account Config";
			this.lnklbl_account_confing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_account_confing_LinkClicked);
			// 
			// lbl_welcome
			// 
			this.lbl_welcome.AutoSize = true;
			this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_welcome.Location = new System.Drawing.Point(350, 13);
			this.lbl_welcome.Name = "lbl_welcome";
			this.lbl_welcome.Size = new System.Drawing.Size(46, 18);
			this.lbl_welcome.TabIndex = 5;
			this.lbl_welcome.Text = "label1";
			// 
			// Mainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(733, 346);
			this.Controls.Add(this.lbl_welcome);
			this.Controls.Add(this.lnklbl_account_confing);
			this.Controls.Add(this.lnklbl_payto);
			this.Controls.Add(this.lnklbl_providers);
			this.Controls.Add(this.lnklbl_expense);
			this.Controls.Add(this.lnklbl_profit);
			this.Name = "Mainform";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Mainform_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel lnklbl_profit;
		private System.Windows.Forms.LinkLabel lnklbl_expense;
		private System.Windows.Forms.LinkLabel lnklbl_providers;
		private System.Windows.Forms.LinkLabel lnklbl_payto;
		private System.Windows.Forms.LinkLabel lnklbl_account_confing;
		private System.Windows.Forms.Label lbl_welcome;
	}
}

