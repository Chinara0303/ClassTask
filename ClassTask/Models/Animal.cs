using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Animal
    {
        public string Name { get; set; }
        //public int Speed { get; set; } = 50;
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
        //public Animal()
        //{
        //    Console.WriteLine("Animal constructor");
        //}

        public void Test()
        {
            Console.WriteLine("Animal test");
        }
    }
}
