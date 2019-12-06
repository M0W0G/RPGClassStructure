using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassStructure
{
    public class Weapon
    {
        private string _id;
        private string _type;
        private int _damage;
        private string _useDescription;

        //Constructors
        public Weapon(string type, int damage, string useDescription)
        {
            _id = IDGenerator.BuildId();
            _type = type;
            _damage = damage;
            _useDescription = useDescription;
        }
        public Weapon(string type, int damage)
        {
            _id = IDGenerator.BuildId();
            _type = type;
            _damage = damage;
            _useDescription = "No description provided yet";
        }

        //Getters and setters
        public string ID
        {
            get { return _id; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public string UseDescription
        {
            get { return _useDescription; }
            set { _useDescription = value; }
        }
    }
}
