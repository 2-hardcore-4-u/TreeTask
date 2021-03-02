using System;
using System.Collections.Generic;
using System.Text;

namespace TreeTask
{
    class Node<T>
    {
        public T value;
        public Node<T> left { get; set; }
        public Node<T> right { get; set; }

        public Node(T v)
        {
            this.value = v;
        }
        public Node()
        {
            this.value = default;
        }
    }
}