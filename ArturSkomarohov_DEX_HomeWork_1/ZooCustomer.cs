using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class ZooCustomer: IZooCustomer
    {
        public virtual void Feed(Animal animal)
        {
            animal.Eat(animal.Feeding);
        }
        public virtual void Watch(Animal animal)
        {
            animal.Show();
        }
        public virtual void WatchAll(Animal[] animals)
        {
            foreach (var item in animals)
            {
                item.Show();
            }
        }
        public virtual void FeedAll(Animal[] animals)
        {
            foreach (var item in animals)
            {
                item.Eat(item.Feeding);
            }
        }
    }
}
