using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__4__16_dy
{
   public abstract class Character
    {
        protected Character(string name, int power, int speed, int health)
        {
            Name = name;
            Power = power;
            Speed = speed;
            Health = health;

        }
        public string Name { get; set; }
        public int Power { get; private set; }
        public int Speed { get; private set; }
        public int Health { get; private set; }
        public abstract void SetPower(int power);
        public abstract void SetSpeed(int speed);
        public abstract void SetHealth(int health);



    }
    public class Hero : Character
    {
        public Hero(string name, int power, int speed, int health) : base(name, power, speed, health)
        {
        }

        public override void SetHealth(int health)
        {
            if (health < 100)
            {
                throw new Exception("Health cannot be less than 100");
            }
           
        }

        public override void SetPower(int power)
        {
            if (power < 40)
            {
                throw new Exception("Power cannot be less than 40");
            }
        }

        public override void SetSpeed(int speed)
        {
            if (speed < 50)
            {
                throw new Exception("Speed cannot be less than 50");
            }
        }
    }
    public class Enemy :Character
    {
        public Enemy(string name, int power, int speed, int health) : base(name, power, speed, health)
        {
        }

        public override void SetHealth(int health)
        {
            if (health < 100)
            {
                throw new Exception("Health cannot be less than 100");
            }

        }

        public override void SetPower(int power)
        {
            if (power < 35)
            {
                throw new Exception("Power cannot be less than 35");
            }
        }

        public override void SetSpeed(int speed)
        {
            if (speed < 20)
            {
                throw new Exception("Speed cannot be less than 20");
            }
        }
    }
    public class NPC :Character
    {
        public NPC(string name, int power, int speed, int health) : base(name, power, speed, health)
        {
        }

        public override void SetHealth(int health)
        {
            if (health < 50)
            {
                throw new Exception("Health cannot be less than 50");
            }

        }

        public override void SetPower(int power)
        {
            if (power < 5)
            {
                throw new Exception("Power cannot be less than 5");
            }
        }

        public override void SetSpeed(int speed)
        {
            if (speed < 5)
            {
                throw new Exception("Speed cannot be less than 5");
            }
        }
    }
}
