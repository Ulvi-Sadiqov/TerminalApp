namespace TerminalApp.Forms
{
	partial class AccountConfig
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
			this.txbx_name = new System.Windows.Forms.TextBox();
			this.btn_edit = new System.Windows.Forms.Button();
			this.txbx_surname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbx_email = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txbx_password = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.go_back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(31, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// txbx_name
			// 
			this.txbx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txbx_name.Location = new System.Drawing.Point(34, 90);
			this.txbx_name.Name = "txbx_name";
			this.txbx_name.Size = new System.Drawing.Size(240, 26);
			this.txbx_name.TabIndex = 1;
			this.txbx_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btn_edit
			// 
			this.btn_edit.BackColor = System.Drawing.Color.Aqua;
			this.btn_edit.FlatAppearance.BorderSize = 0;
			this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_edit.ForeColor = System.Drawing.Color.Black;
			this.btn_edit.Location = new System.Drawing.Point(99, 348);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(97, 41);
			this.btn_edit.TabIndex = 2;
			this.btn_edit.Text = "Edit";
			this.btn_edit.UseVisualStyleBackColor = false;
			this.btn_edit.Click += new System.EventHandler(this.button1_Click);
			// 
			// txbx_surname
			// 
			this.txbx_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txbx_surname.Location = new System.Drawing.Point(34, 163);
			this.txbx_surname.Name = "txbx_surname";
			this.txbx_surname.Size = new System.Drawing.Size(240, 29);
			this.txbx_surname.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(31, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Surname:";
			// 
			// txbx_email
			// 
			this.txbx_email.Enabled = false;
			this.txbx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txbx_email.Location = new System.Drawing.Point(37, 230);
			this.txbx_email.Name = "txbx_email";
			this.txbx_email.Size = new System.Drawing.Size(240, 29);
			this.txbx_email.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(34, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Email:";
			// 
			// txbx_password
			// 
			this.txbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txbx_password.Location = new System.Drawing.Point(37, 305);
			this.txbx_password.Name = "txbx_password";
			this.txbx_password.Size = new System.Drawing.Size(240, 29);
			this.txbx_password.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(34, 275);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "Password:";
			// 
			// go_back
			// 
			this.go_back.BackColor = System.Drawing.Color.Gold;
			this.go_back.FlatAppearance.BorderSize = 0;
			this.go_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.go_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.go_back.ForeColor = System.Drawing.Color.Black;
			this.go_back.Location = new System.Drawing.Point(206, 4);
			this.go_back.Name = "go_back";
			this.go_back.Size = new System.Drawing.Size(97, 26);
			this.go_back.TabIndex = 11;
			this.go_back.Text = "Go Back";
			this.go_back.UseVisualStyleBackColor = false;
			this.go_back.Click += new System.EventHandler(this.go_back_Click);
			// 
			// AccountConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(315, 413);
			this.Controls.Add(this.go_back);
			this.Controls.Add(this.txbx_password);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txbx_email);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txbx_surname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.txbx_name);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AccountConfig";
			this.Text = "AccountConfig";
			this.Load += new System.EventHandler(this.AccountConfig_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbx_name;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.TextBox txbx_surname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbx_email;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbx_password;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button go_back;
	}
}