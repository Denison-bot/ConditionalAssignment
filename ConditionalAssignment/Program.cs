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
        static string condition;
        static string weaponName;
        static int weapon;
        
        static void WeaponChange()
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
                condition = "unscathed";
            }
            else if (health <= 99 && health >= 90)
            {
                condition = "scathed";
            }
            if (health <= 89 && health >= 80)
            {
                condition = "barely bleeding";
            }
            if (health <= 79 && health >= 70)
            {
                condition = "definetly bleeding";
            }
            if (health <= 69 && health >= 60)
            {
                condition = "wincing";
            }
            if (health <= 59 && health >= 50)
            {
                condition = "crying";
            }
            if (health <= 49 && health >= 40)
            {
                condition = "limping";
            }
            if (health <= 39 && health >= 30)
            {
                condition = "bleeding profusely";
            }
            if (health <= 29 && health >= 20)
            {
                condition = "blacking out";
            }
            if (health <= 19 && health >= 10)
            {
                condition = "barely alive";
            }
            if (health <= 9 && health >= 1)
            {
                condition = "basically a corpse";
            }
            if (health == 0)
            {
                condition = "DEAD";
            }
        }

        static void Main(string[] args)
        {

            


        }
    }
}
