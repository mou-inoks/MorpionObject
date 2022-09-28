using System;

namespace TestInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal chat = new Chat();
            IAnimal chien = new Chien();

            chat.Cri();
            chien.Cri();
        }
    }
}
