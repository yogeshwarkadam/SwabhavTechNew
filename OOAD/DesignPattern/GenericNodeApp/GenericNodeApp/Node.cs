using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNodeApp
{
    class Node<T> : IEnumerable<T>
    {
        private T _data;
        private Node<T> _next;

        public Node(T t)
        {

        }
        public T Data
        {
            set { this._date = value; }
            get { return _date; }
        }
        public Node<T>

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
