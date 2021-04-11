using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalApp.Models
{
	public class Provider : Entity
	{
		[Required]
		[MinLength(3)]
		public string Name { get; set; }

	}
}
