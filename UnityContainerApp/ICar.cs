using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainerApp
{
    public interface ICar
    {
        int Drive();
    }

    public class BMW : ICar
    {
        private int _miles = 0;

        public int Drive()
        {
            return ++_miles;
        }
    }

    public class Ford: ICar
    {
        private int _miles = 0;

        public int Drive()
        {
            return ++_miles;
        }
    }

    public class Audi : ICar
    {
        private int _miles = 0;

        public int Drive()
        {
            return ++_miles;
        }
    }

    public class Driver
    {
        private ICar _car = null;
        public Driver(ICar car)
        {
            _car = car;
        }

        public void DriveCar()
        {
            Console.WriteLine("Driving {0} at {1} miles per hour", _car.GetType().Name, _car.Drive());
            Console.ReadLine();
        }
    }


}
