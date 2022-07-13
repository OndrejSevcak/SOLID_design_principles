using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SOLID
{
    public class DIP
    {
        //DEPENDENCY INVERSION PRINCIPLE = is about dependencies among components. 
        // 1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
        // 2. Abstractions should not depend on details. Details should depend on abstractions.

        //IOC = Inversion of Control is a technique to implement the Dependency Inversion Principle in C#.
        //Inversion of control can be implemented using either an abstract class or interface.
        //The rule is that the lower level entities should join the contract to a single interface and
        //the higher-level entities will use only entities that are implementing the interface.
        //This technique removes the dependency between the entities.
    }

    //Applying DIP
    public interface IAutomobile    //ABSTRACTION LAYER
    {
        void Ignition();
        void Stop();
    }
    public class Jeep : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("Jeep starts");

        }

        public void Stop()
        {
            Console.WriteLine("Jeep stops");
        }
    }
    public class SUV : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("SUV starts");
        }

        public void Stop()
        {
            Console.WriteLine("SUV stops");
        }
    }

    public class AutomobileController  //HIGH-LEVEL MODULE
    {
        private readonly IAutomobile _automobile;

        //Injection constructor
        public AutomobileController(IAutomobile automobile)  //Dependency on interface abstraction  
        {
            _automobile = automobile;
        }

        public void Ignition()
        {
            _automobile.Ignition();
        }

        public void Stop()
        {
            _automobile.Stop();
        }
    }

    public class ProgramDIP
    {
        public static void Run()
        {
            IAutomobile automobile = new Jeep();
            AutomobileController controller = new AutomobileController(automobile);
            controller.Ignition();
            controller.Stop();

            IAutomobile suvAutomobile = new SUV();
            AutomobileController suvController = new AutomobileController(suvAutomobile);
            suvAutomobile.Ignition();
            suvAutomobile.Stop();
        }
    }


}
