using System;
using _Attack;

namespace _Weapon
{
    class Weapon
    {
        public Weapon(string name, Attack[] attacks)
        {
            this.Name = name;
            this.Attacks = attacks;
        }
        public Attack[] Attacks { get; set; }
        public string Name { get; set; }
    }
}