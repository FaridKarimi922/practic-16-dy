using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__4__16_dy
{
    internal class Game
    {
        private static List<Character> _characters = new List<Character>();
        public static void AddCharecter(int type, string name, int power, int speed, int health)
        {
            if (type == 1)
            {
                Hero hero = new Hero(name, power, speed, health);
                hero.SetPower(power);
                hero.SetSpeed(speed);
                hero.SetHealth(health);
                _characters.Add(hero);
            }
            else if (type == 2)
            {

                Enemy enemy = new Enemy(name, power, speed, health);
                enemy.SetPower(power);
                enemy.SetSpeed(speed);
                enemy.SetHealth(health);
                _characters.Add(enemy);

            }
            else if (type == 3)
            {
                NPC nPC = new NPC(name, power, speed, health);
                nPC.SetPower(power);
                nPC.SetSpeed(speed);
                nPC.SetHealth(health);
                _characters.Add(nPC);
            }
            else
            {
                Console.WriteLine("Number Not Valid");
            }

        }
        public static List<Character> GetCharecters()
        {
            return _characters;
        }
        public enum status
        {
            live,
            dead
        }
        public static void attack(string nameAtacker, string nameDefender)
        {
            var findAtacker = _characters.Find(_ => _.Name == nameAtacker)!;
            var findDefender = _characters.Find(_ => _.Name == nameDefender)!;

            var healthDefender = findDefender.Health;
            var powerAtacker = findAtacker.Power;
            healthDefender = healthDefender - powerAtacker;

            if (healthDefender <= 0)
            {
                Console.WriteLine(status.dead);
            }
            else
            {
                Console.WriteLine(status.live);
            }


        }

    }







}

