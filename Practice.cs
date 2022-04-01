using System;
using System.Collections;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic type examples :
            MyList<string>stringlist = new MyList<string>();
            stringlist.Add("Ferid");
            stringlist.Add("afsd");
            stringlist.Add("sdfsdfs");
            stringlist[2] = "Sakir";

            Console.WriteLine("\nString list :\n");
            foreach (var item in stringlist.Arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================");
            MyList<int> intlist = new MyList<int>();
            intlist.Add(12);
            intlist.Add(43);
            intlist.Add(1234);

            Console.WriteLine("\nInt list :\n");
            foreach (var item in intlist.Arr)
            {
                Console.WriteLine(item);
            }

            //----------------------------------------
            //Indexer example :
            Console.WriteLine("--------------------");

            Stringlist stringlist1 = new Stringlist();
            stringlist1.Add("adasda");
            stringlist1.Add("sdfsadf");
            stringlist1.Add("adasadasdda");
            stringlist1.Add("fdiidfgd");
            stringlist1[3] = "2342342";



            Console.WriteLine("String list");
            foreach (var item in stringlist1.Arr)
            {
                Console.WriteLine( item);
            }

            //Generic && Non-Generic
            Console.WriteLine("=========Array Collections========");

            ArrayList arrayList = new ArrayList(5);
            arrayList.Add("asdasd");
            arrayList.Add("sadasd");
            arrayList.Add("sadasd");
            arrayList.Add("zfgg");
            arrayList.Add("trtert");
            arrayList.Add("ifdfd");

            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Capacity);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //Sorted list
            Console.WriteLine("\nSorted list");
            SortedList sortedlist = new SortedList();
            sortedlist.Add("A", "Ferid");
            sortedlist.Add("b", "Sakir");
            sortedlist.Add("C","Ixtiyar");
            sortedlist.Add("D", "Huseyn");

            foreach (var item in sortedlist)
            {
                Console.WriteLine(item);
            }
           







        }
    }
}
