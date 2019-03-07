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

    class WeaponStore
    {
        private static string weaponOne = "Longsword";
        private static string weaponTwo = "Daggers";
        private static string weaponThree = "Scimitar";
        private static string weaponFour = "Parry";
        private static string weaponFive = "Quick Attack";

        static Weapon AssembleWeapon(string weaponName, Attack attackOne, Attack attackTwo, Attack attackThree)
        {
            Attack[] Attacks = new Attack[3];
            Attacks[0] = attackOne;
            Attacks[1] = attackTwo;
            Attacks[2] = attackThree;

            return new Weapon(weaponName, Attacks);
        }

        public static Weapon WeaponOne() => AssembleWeapon(weaponOne, AttackStore.AttackOne, AttackStore.AttackTwo, AttackStore.AttackFour);
        public static Weapon WeaponTwo() => AssembleWeapon(weaponTwo, AttackStore.AttackTwo, AttackStore.AttackThree, AttackStore.AttackFive);
        public static Weapon WeaponThree() => AssembleWeapon(weaponThree, AttackStore.AttackThree, AttackStore.AttackFour, AttackStore.AttackOne);
        public static Weapon WeaponFour() => AssembleWeapon(weaponFour, AttackStore.AttackFour, AttackStore.AttackFive, AttackStore.AttackTwo);
        public static Weapon WeaponFive() => AssembleWeapon(weaponFive, AttackStore.AttackFive, AttackStore.AttackOne, AttackStore.AttackThree);
    }
}