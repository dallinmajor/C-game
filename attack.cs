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
}