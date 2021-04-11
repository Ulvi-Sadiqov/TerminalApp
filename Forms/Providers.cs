using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalApp.Models;

namespace TerminalApp.Forms
{
	public partial class Providers : Form
	{
		public Providers()
		{
			InitializeComponent();
		}

		private void Providers_Load(object sender, EventArgs e)
		{
			var providers = GetProvidersByPage(1);

			DrawProviders(providers);

			int count = (int)Math.Ceiling( (decimal)new DBContext().Providers.GetAll().Count() / (decimal) 6);

			DrawPagination(count);
		}

		private void DrawPagination(int count)
		{
			int x = 295;
			for (int i = 1;i<=count;i++) {
				Button button = new Button
				{
					Text = i.ToString(),
					Size = new Size(40,25),
					Location = new Point(x,20)
				};

				button.Click += (s, e) =>
				{
					int c = int.Parse(button.Text);
					var providers = GetProvidersByPage(c).ToList();
					DrawProviders(providers);
				};
				grbx_pagination.Controls.Add(button);
				x += 50;
			}
		}

		private void DrawProviders(IEnumerable<Provider> p)
		{
			Grbx_providers.Controls.Clear();
			var providers = p.ToList();
			int divider = 3;
			int x = 12;
			int y = 31;

			int x1 = 12;
			int y1 = 203;
			for (int i = 0;i<providers.Count();i++)
			{
				if (i<divider) {
					Button button = new Button()
					{
						Size = new Size(205, 148),
						Location = new Point(x, y),
						Text = providers[i].Name
					};
					x += 237;
					Grbx_providers.Controls.Add(button);

				}
				else
				{
					Button button = new Button()
					{
						Size = new Size(205, 148),
						Location = new Point(x1, y1),
						Text = providers[i].Name

					};
					x1 += 237;
					Grbx_providers.Controls.Add(button);

				}

			}
		}

		private IEnumerable<Provider> GetProvidersByPage(int page= 1)
		{
			DBContext dBContext = new DBContext();
			return dBContext.Providers.GetAll().Skip((page - 1)*6).Take(6);
		}
	}
}
