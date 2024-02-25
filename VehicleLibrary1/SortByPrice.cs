using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary1
{
    public class SortByPrice : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Vehicle car1 = (Vehicle)x;
            Vehicle car2 = (Vehicle)y;

            if (car1.Price > car2.Price)
                return 1;
            else if (car1.Price < car2.Price)
                return -1;
            else
                return 0;
        }
    }
}
