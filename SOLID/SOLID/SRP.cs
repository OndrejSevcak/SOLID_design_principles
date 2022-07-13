using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class SRP
    {
        //SINGLE RESPONSIBILITY PRINCIPLE = class should have only one reason to change

        //this means that a class should not be loaded with multiple responsibilities and
        //a single responsibility should not be spread across multiple classes or mixed with other responsibilities.

        //source: https://www.dotnettricks.com/learn/designpatterns/solid-design-principles-explained-using-csharp

    }

    //Understanding the problem
    public class GarageStation
    {
        //the code below, violates SRP principle as it mixes open gate and close gate responsibilities with the main function of servicing of vehicle.
        public void DoOpenGate()
        {
            //open the gate
        }

        public void PerformService() //Wehicle parameter
        {
            //check if garage is open
            //finish wehicle service
        }

        public void DoCloseGate()
        {
            //Close the gate functinality
        }
    }

    //Aplying SRP ->
    //A new interface called IGarageUtility is created and gate related methods are moved to different class called GarageStationUtility.
    public interface IGarageUtility
    {
        void OpenGate();
        void CloseGate();
    }

    public class GarageStationSRP
    {
        private IGarageUtility _garageUtility;

        public GarageStationSRP(IGarageUtility garageUtility)
        {
            _garageUtility = garageUtility;
        }

        public void OpenForService()
        {
            _garageUtility.OpenGate();
        }

        public void DoService()
        {
            //Check if service station is opened and then
            //finish the vehicle service
        }

        public void CloseGarage()
        {
            _garageUtility.CloseGate();
        }
    }

    public class GarageStationUtility : IGarageUtility
    {
        public void CloseGate()
        {
            throw new NotImplementedException();
        }

        public void OpenGate()
        {
            throw new NotImplementedException();
        }
    }

}
