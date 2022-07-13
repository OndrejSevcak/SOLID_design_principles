using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public  class LSP
    {
        //LISKOV SUBSTITUTION PRINCIPLE = functions that use references to base classes must be able to objects of derived class without knowing it

        //LSP states that the child class should be perfectly substitutable for their parent class.
        //If class C is derived from P, then C should be substitutable for P  -- (C by mělo být nahraditelné za P) 

        public LSP()
        {
            Triangle triangle = new Triangle();
            var shape = triangle.GetShape();
        }

    }

    //Understanding the problem -> we can not simply substitude triangle with circle
    public class Triangle //class P
    {
        public virtual string GetShape()
        {
            return "Triangle";
        }
    }

    public class Circle : Triangle //C class is derived from P class
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }

    //Applying LSP using and abstract class

    //ABSTRACT classes and members are incomplete and must be implemented in derived class
    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class TriangleLSP : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class CircleLSP: Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}
