using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class WaterAnimal: Animal
    {
        
        public override void Move()
        {
            
            Console.WriteLine("плаваю в водичке...");
        }
        public override void Eat(Animal animal)
        {
            
            Console.WriteLine("Кушаю " + animal.Name + "...");
        }
    }
}
