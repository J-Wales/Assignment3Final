using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3
{
	public class SLL : ILinkedListADT//<T>
	{
		public Node<User>? Head { get; protected set; }
		public Node<User>? Tail {  get; protected set; }

		//public int count {  get; protected set; }

		public SLL()
		{
			Head = null;
			Tail = null;
			//count = 0;
		}

		public bool IsEmpty()
		{
			if (this.Count() == 0)
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
			Node<User>? newNode = new Node<User>(value); // Create a new node.
			if (Head == null) // If the list is empty, head and tail point to the new node.
			{
				Head = newNode;
			}
			else // If the list is not empty, link current tail to new node and update tail.
			{
				Tail.Next = newNode;
			}
			Tail = newNode;
			//count++; // Increase the count of nodes.

		}

		public void AddFirst(User value)
		{
			Node<User> newNode = new Node<User>(value); // Create a new node.
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
			//count++; // Increase the count of nodes.
		}

		public void Add(User value, int index)
		{
			Node<User> current = Head;

			Node<User> newNode = new Node<User>(value);

			if (index < this.Count())
			{
				for (int i = 0; i < index-1; i++)
				{
					current = current.Next;
				}

				newNode.Next = current.Next;
				current.Next = newNode;
			}
			else
			{
				throw new IndexOutOfRangeException("Index out of range.");
			}
			/*
			while (current != null)
			{

				for (int i = 0; i < index; i++)
				{
					current = current.Next;
				}
			}

			throw new IndexOutOfRangeException("Index out of range.");
			*/
		}

		public void Replace(User value, int index)
		{
			Node<User> current = Head;

			if (current != null)
			{
				for (int i = 0; i < index; i++)
				{
					current = current.Next;
				}
				current.Data = value;
			}
			else
			{
				throw new IndexOutOfRangeException("Index out of range.");
			}
		}

		public int Count()
		{
			Node<User> current = Head;
			int count = 0;
			
			while (current != null)
			{
				current = current.Next;
				count++;
			}
			return count;
		}

		public void RemoveFirst()
		{
			//Checks if list is empty prior to removing the item
            if (Head == null)
            {
				//Throws an exception 
                throw new CannotRemoveException("The list is empty.");
            }

            Head = Head.Next;
        }

		public void RemoveLast()
		{
			//Checks if header is null, Throws an exception if true
            if (Head == null)
            {
                throw new CannotRemoveException("The list is empty.");
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
			Node<User> current = Head;
			while (current != null)
			{
				for (int i = 0; i < index; i++)
				{
					current = current.Next;
				}
				return current.Data;
			}
			throw new IndexOutOfRangeException("Index out of range.");
		}

		public int IndexOf(User value)
		{
			Node<User> current = Head;

			for (int i = 0; i < this.Count(); i++)
			{
				if (current.Data.Equals(value))
				{
					return i;
				}
				current = current.Next;
			}
			return -1;
        }

        // Reverse the order of nodes in the linked list
        public void Reverse()
        {
            var prev = (Node)null;
            var current = Head;
            while (current != null)
            {
                var next = current.Next; // save the next node
                current.Next = prev; // Reverse the link
                prev = current;      //Move to the next pair of nodes
                current = next;
            }
            Head = prev; // The new head is the last node in the original list
        }

        public bool Contains(User value)
		{
			Node<User>? current = Head;
			while (current != null)
			{
				if (current.Data.Equals(value))
				{
					return true; // Found the value.
				}
				current = current.Next;
			}
			return false; // Value not found.
		}

        // Custom exception for when an index cannot be removed
        public class CannotRemoveException : Exception
        {
            public CannotRemoveException(string message) : base(message)
            {
            }
        }
    }
}
