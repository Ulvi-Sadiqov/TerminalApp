using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalApp.Models
{
	public class User:Entity
	{
		public string Name { get; set; }
		public string Surname { get; set; }

	    [Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
		
		public decimal balance { get; set; }
	}
}
