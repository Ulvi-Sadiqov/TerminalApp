using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalApp.Models;

namespace TerminalApp.DataBase
{
	public class DBSet<T> : IDBSet<T> where T:Entity
	{
		private readonly List<T> _items;
		public DBSet()
		{
			_items = new List<T>();
		}

		public void Add(T item)
		{
			_items.Add(item);
		}

		public bool Remove (T item)
		{
			return _items.Remove(item);
		}

		public void Update(T item)
		{
			var listItem = Find(x=>x.Id ==item.Id);
			_items.Remove(listItem);
			_items.Add(item);
		}
		public void RemoveAt(int index)
		{
			_items.RemoveAt(index);
		}

		public IEnumerable<T> GetAsEnumerable()
		{
			foreach (T item in _items)
			{
				yield return item;
			}

		}

		public IEnumerable<T> GetAll()
		{
			return _items;
		}
		public T Find(Predicate<T> predicate)
		{
			return _items.Find(predicate);
		}
	}
}
