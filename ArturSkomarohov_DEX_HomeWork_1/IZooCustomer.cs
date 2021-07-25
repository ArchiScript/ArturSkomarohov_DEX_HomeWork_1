using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    interface IZooCustomer
    {
        void Feed(Animal animal);
        void FeedAll(Animal[] animals);
        void Watch(Animal animal);
        void WatchAll(Animal[] animals);
    }
}
