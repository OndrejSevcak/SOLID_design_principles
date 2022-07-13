using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class OCP
    {
        //OPEN CLOSED PRINCIPLE = software entities should be open for extension and closed for modification

        //class should be easily extended but there is no need to change its core implementations.
        //The OCP states that the behaviors of the system can be extended without having to modify its existing implementation.
    }

    //Understanding the problem

    //take an example of bank accounts like regular savings, salary saving, corporate etc. for different customers
    //as for each customer type, there are different rules and different interest rates

    public class Account
    {
        //The code below violates OCP principle if the bank introduces a new Account type (class will need to be changed)

        public decimal Interest { get; set; }
        public decimal Balance { get; set; }


        public decimal CalcInterest(string accType)
        {
            if(accType == "Regular") //savings
            {
                Interest = (Balance * 4) / 100;
            }
            if (Balance < 1000) Interest -= (Balance * 2) / 100;
            if (Balance < 50000) Interest += (Balance * 4) / 100;

            else if (accType == "Salary") //salary savings
            {
                Interest = (Balance * 5) / 100;
            }
            else if (accType == "Corporate") // Corporate
            {
                Interest = (Balance * 3) / 100;
            }

            return Interest;
        }
    }

    //Aplying OCP ->
    //We can apply OCP by using interface, abstract class, abstract methods and virtual methods when you want to extend functionality.

    public interface IAccount
    {
        public decimal Balance { get; set; }
        decimal CalcInterest();
    }

    public class RegularAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;

        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 4) / 100;
            if (Balance < 1000) Interest -= (Balance * 2) / 100;
            if (Balance < 50000) Interest += (Balance * 4) / 100;

            return Interest;
        }
    }

    public class SavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;

        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 5) / 100;
            return Interest;
        }
    }

    public class CorporateAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;

        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 3) / 100;
            return Interest;
        }
    }

}
