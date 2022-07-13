using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal class ABSTRACT
    {
        //ABSTRACT CLASSES and MEMBERS are incomplete and must be implemented in derived class
        // - can not be instantiated
        // - the purpose is to provide a common definition of a base class that multiple derived classes can share
        // - may also define abstract methods

        //ABSTRACT METHODS
        // - have no implementation
        // - derived classes of the abstract class must implement all abstract methods

        //ADVANTAGES
        // - ability to specify default implementation of methods
        // - added invariant checking to functions
        //have more control in how the "interface" methods are called

        //IMPORTANT -- inheritance vs interface implementation:

        //a TYPE can only be DERIVED from ONE CLASS
        //a TYPE can IMPLEMENT ANY NUMBER of INTERFACES
    }

    public abstract class A
    {
        public abstract void DoWork(int i);
    }

    //Derived classes of abstratc class must implemet all abstract methods
}
