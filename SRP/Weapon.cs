using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Weapon
    {
        private readonly int _power;

        public Weapon(int power)
        {
            _power = power;
        }

        public void Attack()
        {
            // Logic for attacking with the gun
            Console.WriteLine($"The robot attacks with a power {_power}!");
        }
    }
}
