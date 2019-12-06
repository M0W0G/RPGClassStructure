using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassStructure
{
    public class NPC : BaseCharacter
    {
        private string _message;

        //Constructors
        public NPC(string name, string type, string message) : base(name, type)
        {
            _message = message;
        }
        public NPC(string name, string type) : base(name, type)
        {
            
        }
        //Speak Method - Returns the NPCs message
        public string Speak()
        {
            if(_message == null)
            {
            }
            return _message;
        }

        //Getters and setters
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
}
