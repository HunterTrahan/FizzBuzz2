using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    public delegate void ChangeEventHandler(object sender, EventArgs e);
    public delegate void FizzBuzzEventHandler(object sender, EventArgs e);
    class ListWithChangeEvent : ArrayList
    {
        public ChangeEventHandler Changed;
        public FizzBuzzEventHandler Fizz;
        public FizzBuzzEventHandler Buzz;
        public FizzBuzzEventHandler Fizzbuzz;

        //Calls list.Change
        protected virtual void OnChanged(EventArgs e)
        {
            Changed?.Invoke(this, e);
        }

        //Calls list.Fizz
        protected virtual void OnFizz(EventArgs e)
        {
            Fizz?.Invoke(this, e);
        }

        //Calls list.Buzz
        protected virtual void OnBuzz(EventArgs e)
        {
            Buzz?.Invoke(this, e);
        }

        //Calls list.Fizzbuzz
        protected virtual void OnFizzbuzz(EventArgs e)
        {
            Fizzbuzz?.Invoke(this, e);
        }

        //Calls the add functions
        public override void Add(object value)
        {
            base.Add(value);
            OnChanged(EventArgs.Empty);
        }

        //Calls the clear functions
        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        //Fizzbuzz array
        public void FizzBuzz()
        {
            for (int i = 0; i < Length; i++)
            {
                if ((int)this[i] % 3 == 0 && (int)this[i] % 5 == 0)
                {
                    Console.Write(this[i]);
                    OnFizzbuzz(EventArgs.Empty);
                }

                else if ((int)this[i] % 3 == 0)
                {
                    Console.Write(this[i]);
                    OnFizz(EventArgs.Empty);
                }

                else if ((int)this[i] % 5 == 0)
                {
                    Console.Write(this[i]);
                    OnBuzz(EventArgs.Empty);
                }
                //Class the remove functions
                else
                {
                    Remove(i);
                    i--;
                }
            }
        }
    }
}
