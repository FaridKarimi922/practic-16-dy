using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__3__16_dy
{
    public abstract class Car
    {
        protected Car(string name,int speed ,int model)
        {
            Name = name;
            Model =model;
            Speed = speed;
        }
        public string Name { get; set; }
        public int Speed { get; private set; }
        public int Model { get;private set; }
        public abstract void SetSpeed(int speed);
      
        public abstract void SetModel(int model);
        

    }
    public class IranianCar : Car
    {
        public IranianCar(string name, int speed, int model) : base(name, speed, model)
        {
        }

        public override void SetModel(int model)
        {
            if (model < 2012)
            {
                throw new Exception("Iranian car model cannot be less than 2012!!!");
            }
           
        }

        public override void SetSpeed(int speed)
        {
            if (speed > 120)
            {
                throw new Exception("The speed of an Iranian car cannot be more than 120 km");
            }
           
        }
    }
    public class ForeignCar : Car
    {
        public ForeignCar(string name, int speed, int model) : base(name, speed, model)
        {
        }

        public override void SetModel(int model)
        {
            if (model < 2020)
            {
                throw new Exception("Iranian car model cannot be less than 2020!!!");
            }
        }

        public override void SetSpeed(int speed)
        {
            if (speed > 200)
            {
                throw new Exception("The speed of an Iranian car cannot be more than 200 km");
            }
        }
    }
}
