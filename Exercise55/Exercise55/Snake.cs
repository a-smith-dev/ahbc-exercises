using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    class Snake : Reptile
    {
        public override string MoveType => "slither";
        public override void Move()
        {
            Console.WriteLine($"The snake {MoveType}s to the unsuspecting mouse. ");
        }
        public override void Eat()
        {
            Console.WriteLine("The snake swallows its prey. ");
        }
    }
}
