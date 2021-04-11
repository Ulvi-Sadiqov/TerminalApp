using System;
using System.Collections.Generic;
using TerminalApp.Models;

namespace TerminalApp.DataBase
{
	public interface IDBSet<T> where T : Entity
	{
		void Add(T item);
		T Find(Predicate<T> predicate);
		IEnumerable<T> GetAll();
		IEnumerable<T> GetAsEnumerable();
		bool Remove(T item);
		void RemoveAt(int index);
		void Update(T item);
	}
}