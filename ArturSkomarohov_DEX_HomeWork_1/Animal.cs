using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Feeding { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine($"Ням ням ням... кушаю {Feeding}");
        }
        public virtual void Move()
        {
            Console.WriteLine("Передвигаюсь...");
        }
        public virtual void Voice()
        {
            Console.WriteLine("Издаю такие звуки: ...");
        }
        public virtual void Show()
        {
            Console.WriteLine($"Животное {Name}, размер {Size}, "  + 
                $"рацион питания {Feeding}");
        }
    }
}