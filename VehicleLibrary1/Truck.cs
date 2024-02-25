using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary1
{
    public class Truck : Vehicle, IInit
    {
        private int loadCapacity;
        public int LoadCapacity
        {
            get { return loadCapacity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                loadCapacity = value;
            }
        }
        public Truck() { }
        public Truck(string brand, int year, string color, int cost, int clearance,IdNumber id,  int capacity) : base(brand, year, color, cost, clearance, id)
        {
            LoadCapacity = capacity;
        }
        public override void RandomInit()
        {
            base.RandomInit();
            LoadCapacity = rand.Next(1, 10);
        }
        public override void Show()
        {
            base.Show();
            Console.Write($", Грузоподъемность: {LoadCapacity}");
        }
        public override string ToString()
        {
            return base.ToString() + $", , Грузоподъемность: {LoadCapacity}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Truck v = (Truck)obj;
            return LoadCapacity == v.LoadCapacity;
        }
    }
}
