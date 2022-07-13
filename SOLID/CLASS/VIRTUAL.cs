using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.CLASS
{
    public class VIRTUAL
    {
        //VIRTUAL keyword is used to modify a method, property or event declaration and ALLOW for it to be OVERRIDEN in a derived class

        private int x = 5;
        protected int y = 10;  //The protected keyword implies that the object is accessible inside the class and in all classes that derive from that class.


        public virtual double Area()
        {
            return x * y;
        }

        public double Width()
        {
            return x;
        }
    }

    public class TestVirtualOverride : VIRTUAL
    {
        public override double Area()
        {
            return y;
        }

        //public override double Width() { }  -> CAN NOT OVERRIDE INHERITED MEMBER BECAUSE IT IS NOT MARKED VIRTUAL
    }

    public class ProgramTest
    {
        
        private void Test()
        {
            //using derived methods
            TestVirtualOverride testOverride = new TestVirtualOverride();
            var area = testOverride.Area();
            var width = testOverride.Width();
        }
    }
}
