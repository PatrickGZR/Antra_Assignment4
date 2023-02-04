/* Create a Generic Stack class Mystack<T> that can
 * be used any data type which has following methods:
 * 1. int Count()
 * 2. T Pop()
 * 3. void Push()
 */
using System;
namespace Assignment4
{
	public class MyStack<T>
	{
		Stack<T> stack = new Stack<T>();
		public int Count()
		{
			return stack.Count();
		}
		public T Pop()
		{
			return stack.Pop();
		}
		public void Push(T obj)
		{
			stack.Push(obj);
		}
	}

	

}

