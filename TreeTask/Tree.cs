using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TreeTask
{
    class Tree<T> : ITree<T>, IEnumerator<T>
    {
        public Node<T> Root;

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        void ITree<T>.Add(T value)
        {
            throw new NotImplementedException();
        }

        bool ITree<T>.Contains(T value)
        {
            throw new NotImplementedException();
        }

        string ITree<T>.ToString()
        {
            throw new NotImplementedException();
        }
    }

    interface ITree<T>
    {
        void Add(T value);
        bool Contains(T value);
        string ToString();
    }
}