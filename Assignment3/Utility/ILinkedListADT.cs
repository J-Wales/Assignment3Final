﻿using System;
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
            if (File.Exists("testFileName"))
            {
                using (var stream = new FileStream("testFileName", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    if (stream.Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Clears the list.
        /// </summary>
        void Clear()
        {
            using (var stream = new FileStream("testFileName", FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    writer.Write((byte)0);
                }
            }
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
        int Count();

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
