using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_1
{
    public class RectSolid : ISolid
    {
        private double length;
        private double width;
        private double height;

        public RectSolid(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
        {
            return 2 * (length * width + width * height + length * height);
        }
    }
}
