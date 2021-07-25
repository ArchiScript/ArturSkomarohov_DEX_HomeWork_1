using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Predator : Animal
    {
        protected virtual void CatchAnimal(Animal animal)
        {
            Console.WriteLine("Ааа--м .. поймал");
        }
        public override void Eat(dynamic animal)
        {
            CatchAnimal(new Animal());
            Console.WriteLine("Кушаю других животных, вот сегодня" + animal);
        }

    }
}
