using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalApp.Core;
using TerminalApp.Models;

namespace TerminalApp.Forms
{
	public partial class LoginRegisterForm : Form
	{
		public LoginRegisterForm()
		{
			InitializeComponent();
			LoginRegisterControl_Register.btn_operation.Text = "Register";
			loginRegisterControl_Login.btn_operation.Text = "Login";
			#region Login Register Events
			LoginRegisterControl_Register.btn_operation.Click += Btn_operation_Register_Click;
			loginRegisterControl_Login.btn_operation.Click += Btn_operation_Login_Click;
			#endregion
		}

		private void Btn_operation_Login_Click(object sender, EventArgs e)
		{
			User user = new User()
			{
				Email = loginRegisterControl_Login.txbx_email.Text,
				Password = loginRegisterControl_Login.txbx_password.Text
			};

			ValidationContext vs = new ValidationContext(user);
			List<ValidationResult> vr = new List<ValidationResult>();


			if (Validator.TryValidateObject(user, vs, vr, true))
			{
				DBContext dBContext = new DBContext();
				User currentUser = dBContext.Users.Find(x => x.Email == user.Email);
				if (currentUser == null)
				{
					
					MessageBox.Show("Email is not valid!");
				}
				else
				{
					if (currentUser.Password ==user.Password) {
						// do operation

						InMemorySession inMemorySession = new InMemorySession();
						inMemorySession.Add("user" , currentUser);
						inMemorySession.Add("form",this);
						new Mainform().Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Password is not valid!");

					}
				}
			}
			else
			{
				DialogForm dialogForm = new DialogForm();
				dialogForm.FillErrors(vr);
				dialogForm.ShowDialog();
			}
		}


		private void Btn_operation_Register_Click(object sender, EventArgs e)
		{
			User user = new User()
			{
				Email = LoginRegisterControl_Register.txbx_email.Text,
				Password = LoginRegisterControl_Register.txbx_password.Text
			};

			ValidationContext vs = new ValidationContext(user);
			List<ValidationResult> vr = new List<ValidationResult>();


			if (Validator.TryValidateObject(user,vs,vr,true))
			{
				DBContext dBContext = new DBContext();
				User currentUser = dBContext.Users.Find(x=>x.Email == user.Email);
				if (currentUser==null)
				{
					dBContext.Users.Add(user);
					MessageBox.Show("Operation has been succesfully ended");
				}
				else
				{
					MessageBox.Show("This email has already been taken");
				}
			}
			else
			{
				DialogForm dialogForm = new DialogForm();
				dialogForm.FillErrors(vr);
				dialogForm.ShowDialog();
			}
		}

		private void LoginRegisterForm_Load(object sender, EventArgs e)
		{

		}
	}
}
