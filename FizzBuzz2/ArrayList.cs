using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class ArrayList
    {
        private object[] _List;

        public ArrayList()
        {
            _List = new object[0];
        }

        //Original Array
        public virtual void Array(object value)
        {
            object[] _newList = new object[_List.Length + 1];

            for (int i = 0; i < 31; i++)
            {
                _newList[i] = _List[i];
            }

            for (int i = 0; i < _List.Length; i++)
            {
                _newList[i] = _List[i];
            }
            //put the new value at the end of the new array
            _newList[_newList.Length - 1] = value;

            _List = _newList;
        }

        public virtual void Add(object value)
        {
            //Create a new array of Length + 1
            object[] _newList = new object[_List.Length + 1];
            //Put the values of the old array into the new array
            for (int i = 0; i < _List.Length; i++)
            {
                _newList[i] = _List[i];
            }
            //put the new value at the end of the new array
            _newList[_newList.Length - 1] = value;

            _List = _newList;
        }

        public virtual void Remove(int index)
        {
            //Create a new array of length - 1
            object[] _newList = new object[_List.Length - 1];

            //Put the values of the array into the new array
            int newPosition = 0;
            for (int i = 0; i < _List.Length; i++)
            {
                if (i != index)
                {
                    _newList[newPosition] = _List[i];
                    newPosition++;
                }
            }

            //Set the current array to the new array
            _List = _newList;
        }

        //Function to clear
        public virtual void Clear()
        {
            _List = new object[0];
        }

        public virtual object this[int index]
        {
            set
            {
                _List[index] = value;
            }

            get
            {
                return _List[index];
            }
        }

        public int Length
        {
            get
            {
                return _List.Length;
            }
        }
    }
}
