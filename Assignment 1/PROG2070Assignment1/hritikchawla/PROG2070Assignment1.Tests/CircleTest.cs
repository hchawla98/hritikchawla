using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PROG2070Assignment1.Tests
{
    [TestFixture]
    public class CircleTest
    {
        public int r;
        
        [Test]
        public void TestGetArea()
        {
            CircleTest c = new CircleTest();
        }

        [Test]
        public void TestGetRadius()
        {
            CircleTest c = new CircleTest();
        }

        [Test]
        public void TestSetRadius()
        {
            CircleTest c = new CircleTest();
        }

        [Test]
        public void TestGetCircumference()
        {
            CircleTest c = new CircleTest();
        }

        public int GetRadius()
        {
            return r;
        }
        public double GetArea()
        {
            return Math.PI * r * r;
        }
        public double GetCircumference()
        {
            return 2 * Math.PI * r;
        }
        public void SetRadius(int Radius)
        {
            if (Radius >= 1)
            {
                r = Radius;
            }
            else
            {
                Console.WriteLine("Please enter an 00integer greater than 0");
            }
        }
    }
}
