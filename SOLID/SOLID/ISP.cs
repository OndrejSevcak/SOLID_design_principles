using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SOLID
{
    public class ISP
    {
        //INTERFACE SEGREGATION PRINCIPLE = no client should be forced to implement methods which it does not use
        //and the contracts should be broken to thin ones

        //If one class is used in almost all application classes it has become a fat class with overburden
        //Inheriting such class will result in having sharing methods that are not relevant to the derived class but need to be inherited
    }

    //Understanding the problem
    public interface IOrder
    {
        void AddToCard();
        void ProcessByCreditCard();
    }

    public class OnlineOrder : IOrder
    {
        public void AddToCard()
        {
            //add to card
        }

        public void ProcessByCreditCard()
        {
            //process payment
        }
    }

    public class OfflineOrder : IOrder
    {
        public void AddToCard()
        {
            //add to card
        }

        public void ProcessByCreditCard() //This is not required for Offline order, but it need to be implemented
        {
            throw new NotImplementedException();
        }
    }

    //Applying ISP -> diving IOrder to IOrder and IOnlineOrder
    public interface IOrderISP
    {
        void AddToCard();
    }
    public interface IOrderOnline
    {
        void ProcessByCreditCard();
    }

    public class OnlineOrderISP : IOrderISP, IOrderOnline
    {
        public void AddToCard()
        {
            //Add to card
        }

        public void ProcessByCreditCard()
        {
            //pay by creditcard
        }
    }

    public class OfflineOrderISP : IOrderISP
    {
        public void AddToCard()
        {
            //add to card
        }

        public void PayByCash()  //this is not inherited, implemented by interface
        {
            //cash payment
        }
    }


}
