using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Birds:Animal
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine(" летаю..");
        }
    }
}
