using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace full_stack
{
    class CustomStack <T>
    {
        private T [] _ps = new T[300];
        private int _size = 0;

        public void Push(T item)
        {
            this._ps[this._size] = item;
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

        public int NoOfRepetitions(T item)
        {
            int count = 0;

            for (int i = 0; i < this._size; i++)
            {
                if (this._ps[i].Equals(item))
                {
                    count += 1;
                }
            }

            if (count == 0) return -1;
            return count;
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
