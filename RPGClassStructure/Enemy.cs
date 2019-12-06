using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassStructure
{
    public class Enemy : Character
    {
        //Constructors
        public Enemy(string name, string type, int gold, Weapon weapon, int health) : base(name, type, gold, weapon, health)
        {
        }
        //Passes a player in and gives that player the amount of gold it has
        public void DropGold(Player p)
        {
            p.GetGold(this.Gold);
        }
    }
}
