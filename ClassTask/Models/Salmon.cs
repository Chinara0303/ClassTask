using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Salmon:Fish
    {
        public string Color { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Salmon sound");
        }
        //public Salmon()
        //{
        //    Console.WriteLine("Salmon constructor");
        //}
    }
}
