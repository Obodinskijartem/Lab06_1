using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_1
{
    public class Cube : ISolid
    {
        private double edge;

        public Cube(double edge)
        {
            this.edge = edge;
        }

        public double GetSurfaceArea()
        {
            return 6 * Math.Pow(edge, 2);
        }
    }
}
