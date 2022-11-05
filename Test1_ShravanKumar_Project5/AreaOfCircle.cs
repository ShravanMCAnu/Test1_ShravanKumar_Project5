using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project5
{
   public class AreaOfCircle
    {
        public double pi = 3.14159;
        public void CalculateArea(double _radius)
        {
            double area = pi * _radius*_radius;
            Console.WriteLine("Area of the Circle: "+area.ToString("0.0000"));
        }
    }
}
