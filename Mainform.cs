using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalApp.Core;
using TerminalApp.Forms;
using TerminalApp.Models;

namespace TerminalApp
{
	public partial class Mainform : Form
	{
		private InMemorySession session;
		public Mainform()
		{
			InitializeComponent();
			session = new InMemorySession();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new Providers().Show();
			this.Close();
		}

		private void Mainform_Load(object sender, EventArgs e)
		{
			var user = session.Get<User>("user");
			lbl_welcome.Text = $"Hello {user.Email}";
		}

		private void lnklbl_account_confing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AccountConfig accountConfig = new AccountConfig();
			accountConfig.Show();
			this.Hide();
		}
	}
}
