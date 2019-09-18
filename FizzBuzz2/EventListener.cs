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
            List.Fizz += new FizzBuzzEventHandler(Print);
            List.Buzz += new FizzBuzzEventHandler(OnBuzzFound);
            List.Buzz += new FizzBuzzEventHandler(Print);
            List.Fizzbuzz += new FizzBuzzEventHandler(OnFizzbuzzFound);
            List.Fizzbuzz += new FizzBuzzEventHandler(Print);
        }

        private void OnListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("list changed event received");
        }

        private void OnFizzFound(object sender, EventArgs e)
        {
            Console.WriteLine("Fizz");
        }

        private void OnBuzzFound(object sender, EventArgs e)
        {
            Console.WriteLine("Buzz");
        }

        private void OnFizzbuzzFound(object sender, EventArgs e)
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
