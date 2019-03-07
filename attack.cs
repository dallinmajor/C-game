using System;

namespace _Attack
{
    class Attack
    {
        public string[] Weakness { get; set; }

        public string Name { get; set; }
        public Attack(string name, string[] weakness)
        {
            this.Name = name;
            this.Weakness = weakness;
        }
    }

    class AttackStore
    {
        private static string attackOne = "Power Attack";
        private static string attackTwo = "Lunge";
        private static string attackThree = "Double Strike";
        private static string attackFour = "Parry";
        private static string attackFive = "Quick Attack";

        public static Attack AttackOne = new Attack(attackOne, new string[] { attackFive, attackThree });
        public static Attack AttackTwo = new Attack(attackTwo, new string[] { attackOne, attackFour });
        public static Attack AttackThree = new Attack(attackThree, new string[] { attackTwo, attackFive });
        public static Attack AttackFour = new Attack(attackFour, new string[] { attackThree, attackOne });
        public static Attack AttackFive = new Attack(attackFive, new string[] { attackFour, attackTwo });
    }
}