using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    public class Rectangle
    {
        // https://edabit.com/challenge/kpReAapuDjgX2b4em

        public double SideA;
        public double SideB;

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public double GetArea()
        {
            return SideA * SideB;
        }

        public double GetPerimeter()
        {
            return (SideA + SideB) * 2;
        }
    }
}
