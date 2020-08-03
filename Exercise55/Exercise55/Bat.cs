using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    public class Bat : Mammal
    {
        public override string MoveType => "fly";

        public override void Move()
        {
            Console.WriteLine($"The bat would {MoveType} to the tree. ");
        }
        public override void Eat()
        {
            Console.WriteLine("The bat bites the delicious fruit. ");
        }
    }
}
