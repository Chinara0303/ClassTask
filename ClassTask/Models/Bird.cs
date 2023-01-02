using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Bird:Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }
        //public Bird()
        //{
        //    Console.WriteLine("Bird constructor");
        //}
    }
}
