using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp
{
    class MyQueue<T>:Iqueue<T>
    {
        private LinkedList<T> _itemList = new LinkedList<T>();

        public MyQueue()
        {

        }
        public void Enque(T item)
        {
            this._itemList.AddLast(item);
        }
    

        public T Deque()
        {
            var firstItem = _itemList.First();
            this._itemList.RemoveFirst();
            return firstItem;
        }

        public int count()
        {
            return this._itemList.Count();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _itemList.GetEnumerator();

        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _itemList.GetEnumerator();
        }
    }
}
