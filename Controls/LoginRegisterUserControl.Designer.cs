namespace TerminalApp.Controls
{
	partial class LoginRegisterUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_operation = new System.Windows.Forms.Button();
			this.txbx_email = new System.Windows.Forms.TextBox();
			this.txbx_password = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			// 
			// btn_operation
			// 
			this.btn_operation.BackColor = System.Drawing.Color.DodgerBlue;
			this.btn_operation.FlatAppearance.BorderSize = 0;
			this.btn_operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_operation.Location = new System.Drawing.Point(64, 114);
			this.btn_operation.Name = "btn_operation";
			this.btn_operation.Size = new System.Drawing.Size(91, 32);
			this.btn_operation.TabIndex = 5;
			this.btn_operation.Text = "button1";
			this.btn_operation.UseVisualStyleBackColor = false;
			// 
			// txbx_email
			// 
			this.txbx_email.Location = new System.Drawing.Point(6, 28);
			this.txbx_email.Name = "txbx_email";
			this.txbx_email.Size = new System.Drawing.Size(212, 20);
			this.txbx_email.TabIndex = 6;
			// 
			// txbx_password
			// 
			this.txbx_password.Location = new System.Drawing.Point(6, 79);
			this.txbx_password.Name = "txbx_password";
			this.txbx_password.Size = new System.Drawing.Size(212, 20);
			this.txbx_password.TabIndex = 7;
			// 
			// LoginRegisterUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txbx_password);
			this.Controls.Add(this.txbx_email);
			this.Controls.Add(this.btn_operation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LoginRegisterUserControl";
			this.Size = new System.Drawing.Size(221, 156);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Button btn_operation;
		public System.Windows.Forms.TextBox txbx_email;
		public System.Windows.Forms.TextBox txbx_password;
	}
}
