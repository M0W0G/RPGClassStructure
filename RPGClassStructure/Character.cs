using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassStructure
{
    public abstract class Character : BaseCharacter
    {
        private int _gold;
        private Weapon _weapon;
        private int _health;

        //Constructors
        protected Character(string name, string type, int gold, Weapon weapon, int health):base (name, type)
        {
            _gold = gold;
            _weapon = weapon;
            _health = health;
        }
       
        //Changes the weapon of the character
        public void ChangeWeapon(Weapon weapon)
        {
            this.Weapon = weapon;
        }
        //Tests if Character is alive
        public bool IsAliveTest()
        {
            if(this._health >= 1)
            {
                return true;
            }
            return false;
        }
        //Attacking and taking damage methods
        public void Attack(Character c)
        {
            c.TakeDamage(this.Weapon.Damage);
        }
        private void TakeDamage(int damage)
        {
            this.Health -= damage;
        }
        //getters and setters
        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }
        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
    }
}
