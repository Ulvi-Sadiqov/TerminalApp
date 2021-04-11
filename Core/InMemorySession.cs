using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalApp.Models;

namespace TerminalApp.Core
{
	public  class InMemorySession : ISession
	{
		//public static User User { get; set; }
		//public static Form Mainform { get; set; }
		private static readonly Dictionary<string, object> _dictionary;
		static InMemorySession()
		{
			_dictionary = new Dictionary<string, object>();
		}
		

		public void Add<T>(string key, T value)
		{
			_dictionary.Add(key,value);
			
		}

		public T Get<T>(string key)
		{
			return (T)_dictionary[key];
		}
	}
}
