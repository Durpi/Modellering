using System;

namespace modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Player hans = new Player();

            Enemy orc = new Enemy();

            Audience audience = new Audience();

            Console.WriteLine(hans.attack + " is Hans attack damage and " + hans.hp + " is Hans hit points.");
            Console.WriteLine(orc.attack + " is the orcs attack damage and " + orc.hp + " is the orcs hit points.");
            Console.WriteLine("There are " + audience.size + " people in the audience today.");

            Console.ReadLine();

        }
    }
}
