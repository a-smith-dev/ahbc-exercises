using System;

namespace Exercise55
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directions:
            // Create a class hierarchy using animals. Think about: Which properties and methods do all
            // animals share? Which properties and methods do only some animals share? Which properties
            // and methods are unique to a single animal?
            var bat = new Bat();
            bat.Move();
            var snake = new Snake();
            snake.Move();
        }
        static void Story(Animal animal)
        {

        }
    }
}
