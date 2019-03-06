using System;
namespace c_game
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
    class Weapon
    {
        public Weapon(string name, Array[] attacks)
        {
            this.Name = name;
            this.Attacks = attacks;
        }
        public Array[] Attacks { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
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

            var LongSword = new Weapon("LongSword", new List<Attack>(3) {AttackOne, AttackTwo, AttackThree})
            
        }
    }
}
