using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_1
{
    public class RectSolid : Solid
    {
        public double C; // Довжина основи
        public double D; // Ширина основи
        public double H; // Висота

        public RectSolid(double c, double d, double h)
        {
            C = c;
            D = d;
            H = h;
        }

        public override double GetSurfaceArea()
        {
            return 2 * (C * D + D * H + C * H); // Формула площі поверхні прямокутного паралелепіпеда
        }
    }
}
