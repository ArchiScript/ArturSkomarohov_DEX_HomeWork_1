using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class WaterAnimal: Animal
    {
        
        public override void Move()
        {
            base.Move();
            Console.WriteLine("плаваю в водичке...");
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Кушаю водоросли...");
        }
    }
}
