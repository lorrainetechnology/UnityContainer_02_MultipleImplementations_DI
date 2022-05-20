using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace UnityContainerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICar, BMW>();
            unityContainer.RegisterType<ICar, Audi>("LuxuryCar");
            unityContainer.RegisterType<Driver>("LuxuryCarDriver", new InjectionConstructor(unityContainer.Resolve<ICar>("LuxuryCar")));
            
            Driver driver1 = unityContainer.Resolve<Driver>();
            driver1.DriveCar();

            Driver driver2 = unityContainer.Resolve<Driver>("LuxuryCarDriver");
            driver2.DriveCar();
        }
    }
}
