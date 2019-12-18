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
        
        private List<object> _list = new List<object>();

       public void Push(object obj)
       {
           if (obj == null)
           {
               throw new InvalidOperationException();
           }
           else
           {
               var _list = obj;

               this._list.Add(obj);
               
           }

       }

        public object Pop()
        {
            _list.Remove(_list.Count-1);
            return _list.ToString();
        }

        //public void Clear()
        //{

        //}
     
    }
}
