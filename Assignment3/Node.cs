using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    [DataContract]

    public class Node<T>
    {
        // Public property 'Data' holds the value of the node.
        [DataMember]
        public T Data { get; set; }

        // Public property 'Next' points to the next node in the list, initially null.
        [DataMember]
        public Node<T> Next { get; set; }

        // Constructor to initialize a new node with provided data; 'Next' is by default null.
        public Node(T data)
        {
            Data = data; // Set the data part of the node.
        }
    }
}
