using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface
{
    public class Chien : IAnimal
    {
        public void Cri()
        {
            Console.WriteLine("Wouf");
        }
    }
}
