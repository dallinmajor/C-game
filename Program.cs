using System;
using _Weapon;
using _Attack;
using System.Collections.Generic;

namespace c_game
{
    class Program
    {
        static Weapon AssembleWeapon(string weaponName, Attack attackOne, Attack attackTwo, Attack attackThree)
        {
            Attack[] Attacks = new Attack[3];
            Attacks[0] = attackOne;
            Attacks[1] = attackTwo;
            Attacks[2] = attackThree;

            return new Weapon(weaponName, Attacks);
        }
        static void Main(string[] args)
        {
            string attackOne = "Cleave";
            string attackTwo = "Dash Attack";
            string attackThree = "Parry";
            string attackFour = "Power Attack";
            string attackFive = "Devilish Thrust";

            var AttackOne = new Attack(attackOne, new string[] {attackFive, attackThree});
            var AttackTwo = new Attack(attackTwo, new string[] {attackOne, attackFour});
            var AttackThree = new Attack(attackThree, new string[] {attackTwo, attackFive});
            var AttackFour = new Attack(attackFour, new string[] {attackThree, attackOne});
            var AttackFive = new Attack(attackFive, new string[] {attackFour, attackTwo});

            var Attacks = new List<Attack>(3);

            

            
            
        }
    }
}
