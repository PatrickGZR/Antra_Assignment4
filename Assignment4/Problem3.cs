using System;
namespace Assignment4
{
	public interface IgenericRepository<T> where T : class
	{
		public void Add(T item);
		public void Remove(T item);
		public void Save();
		public IEnumerable<T> GetAll();
		public T GetById(int Id);
	}

	public class GenericRepository<T> : IgenericRepository<T> where T : class
	{
		private List<T> list;

		public GenericRepository()
		{
			list = new List<T>();
		}
		public void Add(T item)
		{
			list.Add(item);
		}
		public IEnumerable<T> GetAll()
		{
			return list;
		}
		public T GetById(int id)
		{
			foreach (var item in list)
			{
				if (item.Id == id)
				{
					return item;
				}
			}
			return null;
		}
		public void Remove(T item)
		{
			list.Remove(item);
		}
		public void Save()
		{

		}
	}
}

