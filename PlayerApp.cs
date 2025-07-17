using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationApp
{
    internal class PlayerApp
    {
        public readonly int id;
        public readonly string name;
        public readonly int age;

        public PlayerApp(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public PlayerApp(int id, string name)
        {
            this.id = id;
            this.name = name;
            age = 30;
        }

        public int GetId()
        {
            return this.id;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void WhoIsElder(PlayerApp player1, PlayerApp player2)
        {
            if (player1.GetAge() > player2.GetAge())
            {
                Console.WriteLine($"{player1.GetName()} is elder than {player2.GetName()}");
            }
            else if (player1.GetAge() < player2.GetAge())
            {
                Console.WriteLine($"{player2.GetName()} is elder than {player1.GetName()}");
            }
            else
            {
                Console.WriteLine($"{player1.GetName()} and {player2.GetName()} are of the same age");
            }
        }

    }
}
