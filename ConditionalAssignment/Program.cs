using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalAssignment
{
    class Program
    {
        static int health;
        static string Condition;
        static string weaponName;
        static int weapon;
        
        static void NameChange()
        {
            if (weapon == 0)
            {
                weaponName = "Magnum";
            }
           else if (weapon == 1)
            {
                weaponName = "Shotty";
            }
           else if (weapon == 2)
            {
                weaponName = "Assault Rifle";
            }
            else if (weapon == 3)
            {
                weaponName = "Sniper";
            }
            else if (weapon == 4)
            {
                weaponName = "Railgun";
            }
            else if (weapon == 5)
            {
                weaponName = "Big Friendly Baseball Bat";
            }
        }

        static void healthCheck()
        {
            if (health == 100)
            {
                Condition = "unscathed";
            }
            else if (health  99 90);
        }

        static void Main(string[] args)
        {

      


        }
    }
}
