using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalApp.Models
{
	public class History:Entity
	{
		public int UserId { get; set; }
		public DateTime Date { get; set; }
		public decimal SalaryWas { get; set; }
		public decimal SalaryIs { get; set; }
		public string ProviderName { get; set; }
		public bool IsPaymentAccepted { get; set; }

	}
}
