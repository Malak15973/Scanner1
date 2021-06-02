using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace full_stack
{
    class CustomStack <T>
    {
        private T [] _ps = {};
        private int _size = 0;

        public void Push(T item)
        {
            this._ps[_size+1] = item;
            this._size += 1;
        }

        public Boolean Pop(T item)
        {
            if (_size == 0)
            {
                return false;
            }
            else
            {
                this._size -= 1;
                return true;
            }
        }

        public int Search(T item)
        {
            for (int i = 0; i < this._size; i++)
            {
                if (this._ps[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public int StackSize()
        {
            return this._size;
        }

        public void TraverseStack(Action<T> funct)
        {
            for (int i = 0; i < this._size; i++)
            {
                funct(this._ps[i]);
            }
        }
    }
}
