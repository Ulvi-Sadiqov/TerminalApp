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
	public partial class AccountConfig : Form
	{
		private InMemorySession session;
		public AccountConfig()
		{
			InitializeComponent();
			session = new InMemorySession();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void AccountConfig_Load(object sender, EventArgs e)
		{
			var user = session.Get<User>("user");
			txbx_email.Text = user.Email;
			txbx_name.Text = user.Name;
			txbx_surname.Text = user.Surname;
			txbx_password.Text = user.Password;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			User user = new User
			{
				Email = txbx_email.Text,
				Name = txbx_name.Text,
				Surname = txbx_surname.Text,
				Password = txbx_password.Text
			};
			ValidationContext validationContext = new ValidationContext(user);
			List<ValidationResult> validationResults = new List<ValidationResult>();
			if (Validator.TryValidateObject(user,validationContext,validationResults,true))
			{
				DBContext dBContext = new DBContext();
				dBContext.Users.Update(user);
				User cuser = session.Get<User>("user");
				cuser.Name = user.Name;
				cuser.Surname = user.Surname;
				cuser.Password = user.Password;
			}
			else
			{
				DialogForm dialogForm = new DialogForm();
				dialogForm.FillErrors(validationResults);
				dialogForm.Show();
				this.Hide();
			}
		}

		private void go_back_Click(object sender, EventArgs e)
		{
			new Mainform().Show();
			this.Close();
		}
	}
}
