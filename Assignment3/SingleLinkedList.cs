using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
	internal class SingleLinkedList<T> : ILinkedListADT<T>
	{
		public Node<T> Head { get; protected set; }
		public Node<T> Tail {  get; protected set; }

		public int count {  get; protected set; }

		public bool IsEmpty()
		{

		}

		public void Clear()
		{

		}

		public void AddLast(User value)
		{

		}

		public void AddFirst(User value)
		{

		}

		public void Add(User value, int index)
		{

		}

		public void Replace(User value, int index)
		{

		}

		public int Count()
		{
			return count;
		}

		public void RemoveFirst()
		{

		}

		public void RemoveLast()
		{

		}

		public void Remove(int index)
		{

		}

		public User GetValue(int index)
		{

		}

		public int IndexOf(User value)
		{

		}

		public bool Contains(User value)
		{

		}
	}
}
