using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    interface IAnimal
    {

        void Eat(Animal animal);
        void Eat();
        void Move();
        void Voice();
        void Show();

    }
}
