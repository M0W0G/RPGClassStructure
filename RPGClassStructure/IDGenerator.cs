using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassStructure
{
    public static class IDGenerator
    {
        
        //Generates and returns an id;
        public static string BuildId()
        {
            Random random = new Random();
            return random.Next(99999, 199000).ToString();
        }
    }
}
