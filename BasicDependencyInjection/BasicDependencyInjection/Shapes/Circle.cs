using ConsoleApp3.Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Shapes
{
    public class Circle : IShape
    {
        public void SayShape()
        {
            Console.WriteLine("I am a circle!");
        }
    }
}
