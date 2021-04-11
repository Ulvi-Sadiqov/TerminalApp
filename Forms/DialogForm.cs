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

namespace TerminalApp.Forms
{
	public partial class DialogForm : Form
	{
		public DialogForm()
		{
			InitializeComponent();
		}

		private void DialogForm_Load(object sender, EventArgs e)
		{

		}

		public void FillErrors(List<ValidationResult> vr)
		{
			lbl_errors.Text = String.Empty;
			foreach (var item in vr)
			{
				lbl_errors.Text += item.ErrorMessage + "\n";
			}
		}
	}
}
