using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new list
            ListWithChangeEvent list = new ListWithChangeEvent();

            //Create a class that listens for when the list is changed.
            EventListener listener = new EventListener(list);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(15);
            list.Add(30);
            Console.WriteLine();
            list.PrintList();
            list.FizzBuzz();
            list.PrintBuzz();

            list.Clear();
            listener.Detatch();

            Console.ReadLine();
        }
    }

}
