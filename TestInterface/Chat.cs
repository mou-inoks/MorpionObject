using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface
{
    public class Chat : IAnimal
    {
        public void Cri()
        {
            Console.WriteLine("Meow");
        }
    }
}
