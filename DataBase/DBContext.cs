using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalApp.DataBase;
using TerminalApp.Models;

namespace TerminalApp
{
	public class DBContext
	{
		private static readonly IDBSet<User> _users;
		private static readonly IDBSet<Provider> _providers;
		private static readonly IDBSet<History> _histories;

		public IDBSet<User> Users { get{ return _users; } }

		public IDBSet<Provider> Providers { get { return _providers; } }
		public IDBSet<History> Histories { get { return _histories; } }

		static DBContext()
		{
			_users = new DBSet<User>();
			_users.Add(new User {	
				Email = "test@gmail.com",
				Password="1234"
			});

			_providers = new DBSet<Provider>();
			_histories = new DBSet<History>();
			#region fake providers
			_providers.Add(new Provider
			{
				Id=1,
				Name="Azercell"
			});
			_providers.Add(new Provider
			{
				Id = 2,
				Name = "Nar"
			});
			_providers.Add(new Provider
			{
				Id = 3,
				Name = "Bakcell"
			});
			_providers.Add(new Provider
			{
				Id = 4,
				Name = "AzeriIsiq"
			});
			_providers.Add(new Provider
			{
				Id = 5,
				Name = "AzeriQaz"
			});
			_providers.Add(new Provider
			{
				Id = 6,
				Name = "Xalq Bank"
			});
			_providers.Add(new Provider
			{
				Id = 7,
				Name = "Atabank"
			});
			_providers.Add(new Provider
			{
				Id = 8,
				Name = "Credit"
			});
			_providers.Add(new Provider
			{
				Id = 9,
				Name = "MilliBank"
			});
			#endregion
		}
	}
}
