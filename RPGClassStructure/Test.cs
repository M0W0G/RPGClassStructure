using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassStructure
{
    public static class Test
    {
        //Creates 3 weapons and 2 characters of each type
        public static void DefineCharacters()
        {
            //Type, Damage
            Weapon mace = new Weapon("Mace", 8);
            Weapon sword = new Weapon("Sword", 17);
            Weapon bow = new Weapon("Bow", 11);

            //Name, Type, Gold, Weapon, Health
            Player player1 = new Player("John", "Elf", 34, mace, 100);
            Player player2 = new Player("Tom", "Archer", 0, sword, 95);

            Enemy enemy1 = new Enemy("Josiah", "Troll", 100, mace, 0);
            Enemy enemy2 = new Enemy("George", "Bowman", 45, bow, 100);

            //Name, Type, Message
            NPC npc1 = new NPC("Jill", "Merchant", "Hi! What would you like to buy?");
            NPC npc2 = new NPC("Christoper", "BlackSmith");

            //Prints state of all characters before testing
            Console.WriteLine(String.Format("{0}\nID:{1}\nName:{2}\nType:{3}\nGold:{4}\nWeapon Type:{5}\nWeapon Damage:{6}\nHealth:{7}\n\n", player1.GetType(),player1.Id, player1.Name, player1.Type, player1.Gold, player1.Weapon.Type, player1.Weapon.Damage, player1.Health));
            Console.WriteLine(String.Format("{0}\nID:{1}\nName:{2}\nType:{3}\nGold:{4}\nWeapon Type:{5}\nWeapon Damage:{6}\nHealth:{7}\n\n", player2.GetType(),player2.Id, player2.Name, player2.Type, player2.Gold, player2.Weapon.Type, player2.Weapon.Damage, player2.Health));
                                                             
            Console.WriteLine(String.Format("{0}\nID:{1}\nName:{2}\nType:{3}\nGold:{4}\nWeapon Type:{5}\nWeapon Damage:{6}\nHealth:{7}\n\n", enemy1.GetType(), enemy1.Id, enemy1.Name, enemy1.Type, enemy1.Gold, enemy1.Weapon.Type, enemy1.Weapon.Damage, enemy1.Health));
            Console.WriteLine(String.Format("{0}\nID:{1}\nName:{2}\nType:{3}\nGold:{4}\nWeapon Type:{5}\nWeapon Damage:{6}\nHealth:{7}\n\n", enemy2.GetType(), enemy2.Id, enemy2.Name, enemy2.Type, enemy2.Gold, enemy2.Weapon.Type, enemy2.Weapon.Damage, enemy2.Health));

            Console.WriteLine(String.Format("{0}\nID:{1}\nName:{2}\nType:{3}\nMessage:{4}\n\n", npc1.GetType(), npc1.Id, npc1.Name, npc1.Type, npc1.Message));
            Console.WriteLine(String.Format("{0}\nID:{1}\nName:{2}\nType:{3}\nMessage:{4}\n\n", npc2.GetType(), npc2.Id, npc2.Name, npc2.Type, npc2.Message));

            //Test printouts
            Console.WriteLine("Testing Methods \n");
            //Tests IsAlive()
            Console.WriteLine("IsAlive()");
            Console.WriteLine(String.Format("Expected: True\nActual: {0}", player1.IsAliveTest()));
            Console.WriteLine(String.Format("Expected: False\nActual: {0}", enemy1.IsAliveTest()));

            //Tests ChangeWeapon()
            Console.WriteLine("\nChangeWeapon()");
            enemy1.ChangeWeapon(bow);
            Console.WriteLine(String.Format("Expected: Bow\nActual: {0}",enemy1.Weapon.Type));

            //Tests Attack() / TakeDamage()
            Console.WriteLine("\nAttack() & ChangeWeapon()");
            enemy2.Attack(player1);
            Console.WriteLine(String.Format("Expected: 89\nActual: {0}",player1.Health));

            //Tests DropGold() / GetGold()
            Console.WriteLine("\nDropGold() & GetGold()");
            enemy2.DropGold(player1);
            Console.WriteLine(String.Format("Expected: 79 \nActual: {0}", player1.Gold));

            //Tests Speak()
            Console.WriteLine("\nSpeak()");
            Console.WriteLine(String.Format("Expected: Hi! What would you like to buy?\nActual: {0}", npc1.Speak()));
            
        }
      
    }
}
