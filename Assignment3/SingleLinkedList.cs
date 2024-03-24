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
			//Sets the header to null, essentially clearing the list
            head = null;
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
			//Checks if list is empty prior to removing the item
            if (head == null)
            {
				//Throws an exception upon 
                throw new InvalidOperationException("The list is empty.");
            }

            head = head.Next;
        }

		public void RemoveLast()
		{
			//Checks if header is null, Throws an exception if true
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            else
            {
				//Creates a var to hold current node 
                var currentNode = head;
				//While the list still has nodes, iterates
                while (currentNode.Next != tail)
                {
                    currentNode = currentNode.Next;
                }
				//Once at the second last node sets next node to null
                tail = currentNode;
                tail.Next = null;
            }
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
