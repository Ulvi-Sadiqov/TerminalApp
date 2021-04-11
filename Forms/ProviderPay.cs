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
using TerminalApp.Models;

namespace TerminalApp.Forms
{
	public partial class ProviderPay : Form
	{
		public ProviderPay()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			InMemorySession session = new InMemorySession();
			decimal balance = session.Get<User>("user").balance;
			decimal inputAmount = decimal.Parse(textBox1.Text);

			if (balance < inputAmount)
			{
				MessageBox.Show("You haven't enough money in your balance");
			}
			else
			{
				balance -= inputAmount;
				session.Get<User>("user").balance = balance;
			}
		}
	}
}
