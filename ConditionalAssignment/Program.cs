using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalAssignment
{
    class Program
    {
        static int health = 100;
        static string condition;
        static string weaponName;
        static int weapon;
        static int damage;
        static int hp; //healing int
        static int kills;



        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("=========================");
            Console.WriteLine("Health- " + health);
            Console.WriteLine("Current Weapon- " + weaponName);
            Console.WriteLine("Kills- " + kills);
            healthCheck();
            Console.WriteLine("Condition- " + condition);
            Console.WriteLine("=========================");
            Console.ReadKey(true);
            Console.ResetColor();
        }

        static void getKill()
        {
            kills = kills + 1;
        }

        static void Heal(int hp)
        {
            health = health + hp;
        }

        static void takeDamage(int damage)
        {
            health = health - damage;
        }

        static void WeaponChange(int weapon)
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
                condition = "Unscathed";
            }
            else if (health <= 99 && health >= 75)
            {
                condition = "Scathed";
            }
            else if (health <= 74 && health >= 50)
            {
                condition = "Battered";
            }
            else if (health <= 49 && health >= 25)
            {
                condition = "Bleeding out";
            }
            else if (health <= 24 && health >= 1)
            {
                condition = "Blacking Out";
            }
            else if (health == 0)
            {
                condition = "DEAD";
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Call of Halo: Combat Eternal, New Leaf (with Knuckles)");
            Console.WriteLine("released by Ubisoft Montreal");
            Console.ResetColor();
            Console.WriteLine(" ");

            Console.ReadKey(true);

            WeaponChange(1);

            Console.WriteLine("Multiplayer match found");
            Console.ReadKey(true);
            Console.WriteLine("Starting loadout: ShottyTime");
            Console.ReadKey(true);

            ShowHUD();

            Console.WriteLine("Joined match in progress");
            Console.WriteLine("Get shot from behind for 50 hp immedietly");
            Console.ReadKey(true);

            takeDamage(50);

            ShowHUD();

            Console.WriteLine("Turn around and *blast* that man with your Shotty(TM)");
            Console.ReadKey(true);

            getKill();

            ShowHUD();

            Console.WriteLine("Your foe had a railgun, pick that bad boy up");
            Console.ReadKey(true);

            WeaponChange(4);

            ShowHUD();

            Console.WriteLine("you have a moment to heal, so you pop a medpack");
            Console.WriteLine("heal 25 hp");
            Console.ReadKey(true);

            Heal(25);

            ShowHUD();

            Console.WriteLine("you spot two enemies lined up, time for a collat");
            Console.WriteLine("get 2 kills");
            Console.ReadKey(true);

            getKill();
            getKill();

            ShowHUD();

            Console.WriteLine("your railgun is already out of ammo, so you nab a sniper on the wall");
            Console.ReadKey(true);

            WeaponChange(3);

            ShowHUD();

            Console.WriteLine("You were distracted and took a shot from across the map dealing 40 points of damage");
            Console.ReadKey(true);

            takeDamage(40);

            ShowHUD();

            Console.WriteLine("another shot hits you for 20 hp");
            Console.ReadKey(true);

            takeDamage(20);

            ShowHUD();

            Console.WriteLine("You panic heal, and somehow don't die. gain 25 hp");
            Console.ReadKey(true);

            Heal(25);

            ShowHUD();

            Console.WriteLine("you manage to snipe the person who shot you last");
            Console.WriteLine("get 1 kill");
            Console.ReadKey(true);

            getKill();

            ShowHUD();

            Console.WriteLine("Suddenly your head is no longer attached to your sholders");
            Console.WriteLine("You've been headshot dealing your remaining 40 hp ");
            Console.ReadKey(true);

            takeDamage(40);

            ShowHUD();


            Console.ReadKey(true);

        }
    }
}
