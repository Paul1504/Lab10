using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary1
{
    public class SUV : Vehicle, IInit
    {
        public bool FourWheelDrive { get; set; }
        public string terrainType { get; set; }

        public string TerrainType
        {
            get { return terrainType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Тип бездорожья");
                terrainType = value;
            }
        }
        public override void RandomInit()
        {
            base.RandomInit();
            FourWheelDrive = rand.Next() % 2 == 0;

            string[] roadTypes = { "болото", "сланец", "болото", "камень", "песок" };
            TerrainType = roadTypes[rand.Next(roadTypes.Length)];
        }
        public SUV() { }
        public SUV(string brand, int year, string color, int cost, int clearance, IdNumber id,  bool fourWheelDrive, string terraintype) : base(brand, year, color, cost, clearance, id)
        {
            FourWheelDrive = fourWheelDrive;
            TerrainType = terraintype;
        }
        public override void Show()
        {
            base.Show();
            Console.Write($", Привод: {FourWheelDrive}, Тип бездорожья: {TerrainType}");
        }
        public override string ToString()
        {
            return base.ToString() + $", Привод: {FourWheelDrive}, Тип бездорожья: {TerrainType}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            SUV v = (SUV)obj;
            return FourWheelDrive == v.FourWheelDrive && TerrainType == v.TerrainType;
        }
    }
}
