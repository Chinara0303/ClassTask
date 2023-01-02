using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Eagle:Bird
    {
        public int Speed { get; set; } = 200;
        public override void Sound()
        {
            Console.WriteLine("Eagle sound");
        }
        //public Eagle()
        //{
        //    Console.WriteLine("Eagle constructor");
        //}
        public void Test()
        {
            Console.WriteLine("Eagle test");
        }
    }
}
