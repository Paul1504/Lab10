using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace VehicleLibrary1
{
        public class Vehicle : IInit, ICloneable, IComparable
        {
        private string brand;
        private int year;
        private string color;
        private int price;
        private int groundClearance;
        private IdNumber id;
        protected static Random rand = new Random();

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Brand");
                brand = value;
            }
        }
        public object Clone()
        {
            return new Vehicle(Brand, Year, Color, Price, GroundClearance, id);
        }
        public Vehicle ShallowCopy()
        {
            return (Vehicle)this.MemberwiseClone();
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 2024 || value < 2000)
                    throw new ArgumentException();
                year = value;
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Color");
                color = value;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                price = value;
            }
        }

        public int GroundClearance
        {
            get { return groundClearance; }
            set
            {
                if (value < 0 || value > 20)
                    throw new ArgumentException();
                groundClearance = value;
            }
        }
        public IdNumber Id { get { return id; } }
        public Vehicle()
            {
                Brand = "BMW";
                Year = 2005;
                Color = "Black";
                Price = 10000;
                GroundClearance = 5;
            }

            public Vehicle(string brand, int year, string color, int price, int groundClearance, IdNumber id)
            {
                Brand = brand;
                Year = year;
                Color = color;
                Price = price;
                GroundClearance = groundClearance;
                this.id = id;
        }

            public virtual void Show()
            {
                Console.WriteLine($"Бренд: {Brand}, Год: {Year}, Цвет: {Color}, Цена(в рублях): {Price}, Дорожный просвет: {GroundClearance}");
            }
        public override string ToString()
        {
            return $"Модель = {Brand}, Год выпуска = {Year}, Цвет = {Color}, Стоимость = {Price}, Дорожный просвет = {GroundClearance}";
        }
        public virtual void Init()
            {
                Console.WriteLine("Введите бренд:");
                Brand = Console.ReadLine();
                Console.WriteLine("Введите год выпуска:");
                Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите цвет:");
                Color = Console.ReadLine();
                Console.WriteLine("Введите цену:");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите дорожный просвет:");
                GroundClearance = Convert.ToInt32(Console.ReadLine());
            }

            public virtual void RandomInit()
            {
                string[] brands = { "KIA", "BMW", "Mercedes", "Lada", "Opel", "Lamborgini", "Volswagen", "Chevrolet", "Renault", "Ferrai" };
                string[] colors = { "Красный", "Желтый", "Черный", "Белый", "Серебристый", "Розовый", "Оранжевый", "Зеленый", "Синий", "Голубой" };
                int s = rand.Next(brands.Length);
                Brand = brands[rand.Next(brands.Length)]; ;
                Year = rand.Next(2001, 2023);
                Color = colors[rand.Next(colors.Length)]; ;
                Price = rand.Next(10000, 500000);
                GroundClearance = rand.Next(5, 15);
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Vehicle v = (Vehicle)obj;
                return Brand == v.Brand && Year == v.Year && Color == v.Color && Price == v.Price &&
                       GroundClearance == v.GroundClearance;
            }
        public int CompareTo(Vehicle? other)
        {
            return Brand.CompareTo(other.brand);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Car other)
                return Brand.CompareTo(other.brand);
            return 0;
        }
    }
}