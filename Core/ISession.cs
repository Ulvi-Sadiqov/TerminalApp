using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalApp
{
	public interface ISession
	{
		void Add<T>(string key , T value);
		T Get<T>(string key);
	}
}
