using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp38
{
    class Stringlist
    {
        string[] arr = new string[0];

        public string this[int indexer] 
        {
            get
            {
                return arr[indexer];
            }
            set
            {
                arr[indexer] = value;
            }
        }

        public string[] Arr { get => arr; }
        public void Add(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = str;
            }
        }

    }
}
