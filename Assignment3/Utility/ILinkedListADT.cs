using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public interface ILinkedListADT//<T>
    {
        /// <summary>
        /// Checks if the list is empty.
        /// </summary>
        /// <returns>True if it is empty.</returns>
        public bool IsEmpty()
        {
            
        }

        /// <summary>
        /// Clears the list.
        /// </summary>
        void Clear()
        {
            // Deserialize the list of users
            ILinkedListADT users = SerializationHelper.DeserializeUsers(testFileName);

            // Create an empty list
            List<User> emptyList = new List<User>();

            // Serialize the empty list to the same file
            SerializationHelper.SerializeUsers(emptyList, fileName);
        }

        /// <summary>
        /// Adds to the end of the list.
        /// </summary>
        /// <param name="value">Value to append.</param>
        void AddLast(User value);

        /// <summary>
        /// Prepends (adds to beginning) value to the list.
        /// </summary>
        /// <param name="value">Value to store inside element.</param>
        void AddFirst(User user)
        {
            
        }

        /// <summary>
        /// Adds a new element at a specific position.
        /// </summary>
        /// <param name="value">Value that element is to contain.</param>
        /// <param name="index">Index to add new element at.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if index is negative or past the size of the list.</exception>
        void Add(User value, int index);

        /// <summary>
        /// Replaces the value  at index.
        /// </summary>
        /// <param name="value">Value to replace.</param>
        /// <param name="index">Index of element to replace.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if index is negative or larger than size - 1 of list.</exception>
        void Replace(User value, int index);

        /// <summary>
        /// Gets the number of elements in the list.
        /// </summary>
        /// <returns>Size of list (0 meaning empty)</returns>
       int Count()
        {
            // Deserialize the list of users
            ILinkedListADT users = SerializationHelper.DeserializeUsers(testFileName);

            // Return 0 if the list is empty
            if (users.IsEmpty())
            {
                return 0;
            }

            // Otherwise, return the count of items in the list
            int count = 0;
            Node<User> current = users.Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        /// <summary>
        /// Removes first element from list
        /// </summary>
        /// <exception cref="CannotRemoveException">Thrown if list is empty.</exception>
        void RemoveFirst();

        /// <summary>
        /// Removes last element from list
        /// </summary>
        /// <exception cref="CannotRemoveException">Thrown if list is empty.</exception>
        void RemoveLast();

        /// <summary>
        /// Removes element at index from list, reducing the size.
        /// </summary>
        /// <param name="index">Index of element to remove.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if index is negative or larger than size - 1 of list.</exception>
        void Remove(int index);

        /// <summary>
        /// Gets the value at the specified index.
        /// </summary>
        /// <param name="index">Index of element to get.</param>
        /// <returns>Value of node at index</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown if index is negative or larger than size - 1 of list.</exception>
        User GetValue(int index);

        /// <summary>
        /// Gets the first index of element containing value.
        /// </summary>
        /// <param name="value">Value to find index of.</param>
        /// <returns>First of index of node with matching value or -1 if not found.</returns>
        int IndexOf(User value);

        /// <summary>
        /// Go through nodes and check if one has value.
        /// </summary>
        /// <param name="value">Value to find index of.</param>
        /// <returns>True if element exists with value.</returns>
        bool Contains(User value);
    }
}
