using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using System.Text;
using System.Threading.Tasks;


namespace Assignment3
{
	[DataContract]
    [KnownType(typeof(SLL))]
	
	public class SLL : ILinkedListADT
    {
		[DataMember]
        public Node<User> Head { get; set; }
		[DataMember]
		public Node<User> Tail { get; set; }

		public SLL()
        {
            Head = null;
            Tail = null;
        }

        // Check if list is empty
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
        
		// Add a node with the spcified value to the end of the list.
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

		// Add a node with the spcified value to the start of the list.
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
		}
		
        // Add a node with the spcified value at the specified index.
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
		}
		
        // Replace the value of the node at the specified index with the specified value.
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
		
        // Count the number of nodes in the list.
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
		
        // Remove the first node in the list.
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
		
        // Remove the last node in the list.
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
		
        // Remove the node at the specified index.
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
		
        // Get the value of the node at the specified index.
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
        
		// Get the index of a the first node with the specified value.
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
            var prev = (Node<User>)null;
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
