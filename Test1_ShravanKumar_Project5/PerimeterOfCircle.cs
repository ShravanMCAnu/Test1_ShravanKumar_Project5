using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project5
{
    public class PerimeterOfCircle:AreaOfCircle
    {
        public void CalculatePerimeter(double _radius)
        {
            double perimeter = 2 * pi * _radius;
            Console.WriteLine("Perimeter of Circle:" + perimeter.ToString("0.0000"));   
        }
    }
}
