using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class GroundAnimal:Animal
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Я хожу по земле..");
        }
        public override void Voice()
        {
            Console.WriteLine("Издаю такие звуки: ...");
        }
    }
}
