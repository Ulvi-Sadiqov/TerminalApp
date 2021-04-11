namespace TerminalApp.Forms
{
	partial class LoginRegisterForm
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
			this.grbx_register = new System.Windows.Forms.GroupBox();
			this.LoginRegisterControl_Register = new TerminalApp.Controls.LoginRegisterUserControl();
			this.grbx_login = new System.Windows.Forms.GroupBox();
			this.loginRegisterControl_Login = new TerminalApp.Controls.LoginRegisterUserControl();
			this.grbx_register.SuspendLayout();
			this.grbx_login.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbx_register
			// 
			this.grbx_register.Controls.Add(this.LoginRegisterControl_Register);
			this.grbx_register.Location = new System.Drawing.Point(38, 49);
			this.grbx_register.Name = "grbx_register";
			this.grbx_register.Size = new System.Drawing.Size(240, 191);
			this.grbx_register.TabIndex = 0;
			this.grbx_register.TabStop = false;
			this.grbx_register.Text = "Register";
			// 
			// LoginRegisterControl_Register
			// 
			this.LoginRegisterControl_Register.Location = new System.Drawing.Point(13, 19);
			this.LoginRegisterControl_Register.Name = "LoginRegisterControl_Register";
			this.LoginRegisterControl_Register.Size = new System.Drawing.Size(221, 156);
			this.LoginRegisterControl_Register.TabIndex = 0;
			// 
			// grbx_login
			// 
			this.grbx_login.Controls.Add(this.loginRegisterControl_Login);
			this.grbx_login.Location = new System.Drawing.Point(387, 49);
			this.grbx_login.Name = "grbx_login";
			this.grbx_login.Size = new System.Drawing.Size(241, 191);
			this.grbx_login.TabIndex = 1;
			this.grbx_login.TabStop = false;
			this.grbx_login.Text = "Login";
			// 
			// loginRegisterControl_Login
			// 
			this.loginRegisterControl_Login.Location = new System.Drawing.Point(14, 19);
			this.loginRegisterControl_Login.Name = "loginRegisterControl_Login";
			this.loginRegisterControl_Login.Size = new System.Drawing.Size(221, 156);
			this.loginRegisterControl_Login.TabIndex = 1;
			// 
			// LoginRegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(675, 297);
			this.Controls.Add(this.grbx_login);
			this.Controls.Add(this.grbx_register);
			this.Name = "LoginRegisterForm";
			this.Text = "LoginRegisterForm";
			this.Load += new System.EventHandler(this.LoginRegisterForm_Load);
			this.grbx_register.ResumeLayout(false);
			this.grbx_login.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbx_register;
		private Controls.LoginRegisterUserControl LoginRegisterControl_Register;
		private System.Windows.Forms.GroupBox grbx_login;
		private Controls.LoginRegisterUserControl loginRegisterControl_Login;
	}
}