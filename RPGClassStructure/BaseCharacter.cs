using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassStructure
{
    public abstract class BaseCharacter
    {
        private string _id;
        private string _name;
        private string _type;

        //Constructors
        protected BaseCharacter(string name, string type)
        {
            _id = IDGenerator.BuildId(); ;
            _name = name;
            _type = type;
        }






        //getters and setters
        public string Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

    }
}
