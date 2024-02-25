using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary1
{
    public class Car : Vehicle, IInit
    {
        private int seatCount;
        private int maxSpeed;
        public int SeatCount
        {
            get { return seatCount; }
            set
            {
                if (value < 0 || value > 7)
                    throw new ArgumentException();
                seatCount = value;
            }
        }

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value < 0 || value > 300)
                    throw new ArgumentException();
                maxSpeed = value;
            }
        }
        public Car()
        {

        }
        public Car(string brand, int year, string color, int cost, int clearance, IdNumber id, int seatCount, int maxSpeed) : base(brand, year, color, cost, clearance, id)
        {
            SeatCount = seatCount;
            MaxSpeed = maxSpeed;
        }
        public override void RandomInit()
        {
            base.RandomInit();
            SeatCount = rand.Next(2, 8);
            MaxSpeed = rand.Next(100, 300);
        }
        public override void Show()
        {
            base.Show();
            Console.Write($", Количество мест: {SeatCount}, Максимальная скорость(в км/ч): {MaxSpeed}");
        }
        public override string ToString()
        {
            return base.ToString() + $", Количество мест = {SeatCount}, Максимальная скорость(в км/ч): {MaxSpeed}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Car v = (Car)obj;
            return SeatCount == v.SeatCount && MaxSpeed == v.MaxSpeed;
        }
    }
}
