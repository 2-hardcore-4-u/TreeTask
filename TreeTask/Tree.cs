using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TreeTask
{
    class Tree<T> : ITree<T>, IEnumerator<T> where T: IComparable
    {
        public Node<T> root;

        public Tree()
        {
            root = null;
        }

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
            Node<T> newItem = new Node<T>(value);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                Node<T> current = root;
                Node<T> parent = null;
                while (current != null)
                {
                    parent = current
                    if (value.CompareTo(current.value) >= 0)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newItem;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newItem;
                        }
                    }
                }
            }
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