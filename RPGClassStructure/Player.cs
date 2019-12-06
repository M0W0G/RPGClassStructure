using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassStructure
{
    public class Player : Character
    {
        //Constructors
        public Player(string name, string type, int gold, Weapon weapon, int health) : base(name, type, gold, weapon, health)
        {
        }
        //Called by Attack()
        public void GetGold(int gold)
        {
            this.Gold += gold;
        }
    }

    
}
