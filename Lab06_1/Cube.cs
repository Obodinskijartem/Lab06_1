using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_1
{
    public class Cube : Solid
    {
        public double A;

        public Cube(double a)
        {
            A = a;
        }

        public override double GetSurfaceArea()
        {
            return 6 * Math.Pow(A, 2);
        }
    }
}
