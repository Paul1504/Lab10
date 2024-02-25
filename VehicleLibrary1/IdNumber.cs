using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary1
{
    public class IdNumber
    {
        private int number;

        public IdNumber(int number)
        {
            Number = number;
        }

        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Number");
                number = value;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            IdNumber v = (IdNumber)obj;
            return this.number == v.number;
        }

        public override string ToString()
        {
            return number.ToString();
        }
    }
}
