using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class queue<T>
    {
        List<T> _queue;


        public queue()
        {
            _queue = new List<T>();
        }

        public queue(T firstElement)
        {
            _queue = new List<T> { firstElement };
        }
        
        public void Add(T element) { _queue.Add(element); }
        public T Remove() 
        { 
            T _object = _queue[0];
            _queue.RemoveAt(0); 
            return _object;
        }

        public T Peek()
        {
            return _queue[0];
        }


    }
}
