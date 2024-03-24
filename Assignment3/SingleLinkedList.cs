using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
	internal class SingleLinkedList<T> : ILinkedListADT<T>
	{
		public Node<User> Head { get; protected set; }
		public Node<User> Tail {  get; protected set; }

		public int count {  get; protected set; }

		public bool IsEmpty()
		{
			if (count == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Clear()
		{
			//Sets the header to null, essentially clearing the list
            Head = null;
        }

		public void AddLast(User value)
		{

		}

		public void AddFirst(User value)
		{
			/*
			Node<T> newNode = new Node<T>(data); // Create a new node.
			if (Head == null) // If the list is empty, head and tail point to the new node.
			{
				Head = newNode;
				Tail = newNode;
			}
			else // If the list is not empty, link new node to the existing head and update head.
			{
				newNode.Next = Head;
				Head = newNode;
			}
			Count++; // Increase the count of nodes.
			*/
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
            if (Head == null)
            {
				//Throws an exception upon 
                throw new InvalidOperationException("The list is empty.");
            }

            Head = Head.Next;
        }

		public void RemoveLast()
		{
			//Checks if header is null, Throws an exception if true
            if (Head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            else
            {
				//Creates a var to hold current node 
                var currentNode = Head;
				//While the list still has nodes, iterates
                while (currentNode.Next != Tail)
                {
                    currentNode = currentNode.Next;
                }
				//Once at the second last node sets next node to null
                Tail = currentNode;
                Tail.Next = null;
            }
        }

		public void Remove(int index)
		{
			//If index points to start of list, call remove first method
			if (index == 0)
			{
				RemoveFirst();
			}
			else
			{
				var currentNode = Head;
				//Iterates through the linked list
				for (int i = 0; i < index - 1; i++)
				{
					currentNode = currentNode.Next;
				}
				//creates a var to hold the node that is gonna be removed
				var nodeToRemove = currentNode.Next;
				currentNode.Next = nodeToRemove.Next;
				//Sets the previous node from the removed node as the new tail
				Tail = currentNode;

			}
		}

		public User GetValue(int index)
		{

		}

		public int IndexOf(User value)
		{
			Node<User> current = Head;
			/*
			Node<User> newNode = new Node<User>(value);
			var currentNode = Head;

			int index = -1;

			for (int i = 0; i < this.Count(); i++)
			{
				if (newNode == currentNode)
				{
					index = i;
				}
				currentNode.Next;
			}

			return index;
			*/
		}

		public bool Contains(User value)
		{
			Node<T>? current = Head;
			while (current != null)
			{
				if (current.Data.Equals(value))
				{
					return true; // Found the value.
				}
				current = current.Next;
			}
			return false; // Value not found.


			bool found = false;

			for (int i = 0; i < this.Count(); i++)
			{

			}

			return found;
		}
	}
}
