using System;
namespace Assignment4
{
	public class MyList<T>
	{
		private List<T> list;
		private int Count;
		private static int MINLENGTH = 100;
		public MyList()
		{
			list = new List<T>();
		}
		public void Add(T element)
		{
			list.Add(element);
		}

		public bool Contains(T element)
		{
			foreach (var i in list)
			{
				if (i.Equals(element))
				{
					return true;
				}
				return false;
			}
			throw new ArgumentException();
		}

		public void Clear()
		{
			while(list.Count > 0)
			{
				list.RemoveAt(0);
			}
		}

		public void InsertAt(T element, int index)
		{
			int i = 0;
			while (i <= index)
			{
				if (i < index)
				{
					i++;
				}
				else
				{
					Add(element);
				}
			}
		}
		public void DeleteAt(int index)
		{
			if (index < 0 || index > list.Count)
			{
				throw new ArgumentOutOfRangeException("inidex");
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (i == index)
				{
					list.Remove(list[i]);
					break;
				}
			}
		}

		public T Find(int index)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (i == index)
				{
					return list[i];
				}
			}
			throw new IndexOutOfRangeException();
		}
	}
}

