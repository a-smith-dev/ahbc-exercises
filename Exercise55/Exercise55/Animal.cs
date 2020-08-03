using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    public class Animal
    {
        public virtual string MoveType { get; }
        public virtual string SkinType { get; }
        public virtual void Move()
        {
            Console.WriteLine("it moves.");
        }
        public virtual void Eat()
        {
            Console.WriteLine("it eats the thing.");
        }
    }
}
