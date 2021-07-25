using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public class Animal : IAnimal
    {
               
        public string Name { get; set; }
        public string Size { get; set; }
        public dynamic Feeding { get; set; }
        public string Sound { get; set; }

        public virtual void Eat(dynamic Feeding)
        {
            Console.WriteLine($"Ням ням ням... кушаю {Feeding}");
        }

        public virtual void Move()
        {
            Console.WriteLine("Передвигаюсь...");
        }
        public virtual void Voice()
        {
            Console.WriteLine($"Издаю такие звуки: ... {Sound}");
        }
        public virtual void Show()
        {
            Console.WriteLine($"Животное {Name}, размер {Size}, " +
                $"рацион питания {Feeding}");
            this.Voice();
            this.Move();
        }
        


    }
}