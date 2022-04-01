using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp38
{
    internal class MyList<T>
    {
        T[] arr = new T[0];
        public T this[int indexer]
        {
            get
            {
                if (arr.Length - 1 >= indexer)
                {
                return arr[indexer];
                }
                else
                {
                    throw new IndexOutOfRangeException("bele bir index yoxdur!!");
                }
            }
            set
            {
                if (arr.Length - 1 >= indexer)
                {
                  arr[indexer]=value;
                }
                else
                {
                    throw new IndexOutOfRangeException("bele bir index yoxdur!!");
                }
            }
        }
        public T[] Arr { get => arr; }
        
        public void Add(T str)
        {            
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = str;
            
        }
    }
}
