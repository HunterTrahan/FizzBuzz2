using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class EventListener
    {
        private ListWithChangeEvent List;

        public EventListener(ListWithChangeEvent list)
        {
            List = list;
            List.Changed += new ChangeEventHandler(OnListChanged);
            List.Fizz += new FizzBuzzEventHandler(OnFizzFound);
            List.Buzz += new FizzBuzzEventHandler(OnBuzzFound);
            List.Fizzbuzz += new FizzBuzzEventHandler(OnFizzbuzzFound);
        }

        //Tells the program to write 'list changed event recived'
        //when the list is changed
        public void OnListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("list changed event received");
        }
        
        //Tells the program to write 'Fizz'
        //when Fizz is found
        public void OnFizzFound(object sender, EventArgs e)
        {
            Console.WriteLine("Fizz");
        }

        //Tells the program to write 'Buzz'
        //when Buzz is found
        public void OnBuzzFound(object sender, EventArgs e)
        {
            Console.WriteLine("Buzz");
        }

        //Tells the program to write 'Fizzbuzz'
        //when Fizzbuzz is found
        public void OnFizzbuzzFound(object sender, EventArgs e)
        {
            Console.WriteLine("Fizzbuzz");
        }

        public void Detatch()
        {
            List.Changed -= new ChangeEventHandler(OnListChanged);
            List = null;
        }
    }
}
