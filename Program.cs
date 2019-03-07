using System;
using _Weapon;
using _Attack;
using System.Collections.Generic;

namespace c_game
{
    class Program
    {
        static void Main(string[] args)
        {
            var Longsword = WeaponStore.WeaponOne();
            var Daggers = WeaponStore.WeaponTwo();
            var Scimitars = WeaponStore.WeaponThree();
            var Rapier = WeaponStore.WeaponFour();
            var BattleAxe = WeaponStore.WeaponFive();

            Console.WriteLine(Longsword.Name);
            Console.WriteLine(Daggers.Name);
            Console.WriteLine(Scimitars.Name);
            Console.WriteLine(Rapier.Name);
            Console.WriteLine(BattleAxe.Name);
        }
    }
}
