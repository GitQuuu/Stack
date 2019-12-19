using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        private  readonly List<object> _list = new List<object>();

       public void Push(object obj)
       {
           if (obj == null)
           {
               throw new InvalidOperationException();
           }
           else
           {
               var _list = (obj);

               this._list.Add(obj);
               
           }

       }

        public object Pop()
        {
            object lastInFirstOut = 0;

            if (_list == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                lastInFirstOut = _list.ElementAt(_list.Count - 1);
                Clear();
            }

            return lastInFirstOut;
        }

        public void Clear()
        {
            _list.RemoveAt(_list.Count - 1);
        }

    }
}
