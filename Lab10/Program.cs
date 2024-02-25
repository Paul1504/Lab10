using System;
using VehicleLibrary1;
namespace Lab10

{
    internal class Program
    {
        static Vehicle FindMaxCost(Vehicle[] cars)
        {
            Vehicle result = null;
            int maxCost = 0;
            foreach (Vehicle car in cars)
            {
                if (car is SUV && car.Price > maxCost)
                {
                    result = car;
                    maxCost += car.Price;
                }
            }
            return result;
        }
        static double AverageSpeed(Vehicle[] cars)
        {
            int count = 0;
            int sumSpeed = 0;
            foreach (Vehicle car in cars)
            {
                if (car is Car)
                {
                    Car Car = car as Car;
                    sumSpeed += Car.MaxSpeed;
                    count++;
                }
            }
            if (count > 0)
            {
                double avg = (double)sumSpeed / count;
                return avg;
            }
            return 0;
        }
        static int SumCost(Vehicle[] cars)
        {
            int sumCost = 0;
            foreach (Vehicle car in cars)
            {
                    sumCost += car.Price;
            }
            return sumCost;
        }
        static void FillArrayCars(IInit[] cars)
        {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (i % 4 == 0)
                        cars[i] = new Vehicle();
                    else if (i % 4 == 1)
                        cars[i] = new Car();
                    else if (i % 4 == 2)
                        cars[i] = new SUV();
                    else
                        cars[i] = new Truck();
                    cars[i].RandomInit();
                } 
        }
        static void ShowArray(IInit[] cars)
        {
            foreach (var vehicle in cars)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
        static void Main(string[] args)
        {
            int answ;
            bool isSucceed;
            Vehicle[] vehicles = new Vehicle[20];
            IInit[] cars = new IInit[10];
            do
            {
                Console.WriteLine('\n' + "1. Создать лист машин из 20 элементов");
                Console.WriteLine("2. Вывести среднюю скорость легковых автомобилей");
                Console.WriteLine("3. Вывести максимальную скорость среди всех автомобилей");
                Console.WriteLine("4. Вывести сумму цен всех автомобилей из списка");
                Console.WriteLine("5. Создать лист машин с помощью IInit из 10 машин");
                Console.WriteLine("6. Узнать количество легковых, грузовых машин и внедорожников ");
                Console.WriteLine("7. Отсортировать лист машин по стоимости");
                Console.WriteLine("8. Найти позицию автомобиля");
                Console.WriteLine("9. Clone и ShallowCopy");
                Console.WriteLine("10. Выход ");
                do
                {
                    string tmp = Console.ReadLine();
                    isSucceed = int.TryParse(tmp, out answ);
                    if (!isSucceed)
                    {
                        Console.WriteLine("Неверный ввод.Попробуйте еще раз.");
                    }
                } while (!isSucceed);
                switch (answ)
                {
                        case 1:
                        {
                            for (int i = 0; i < vehicles.Length; i++)
                            {
                                if (i % 4 == 0)
                                    vehicles[i] = new Vehicle();
                                else if (i % 4 == 1)
                                    vehicles[i] = new Car();
                                else if (i % 4 == 2)
                                    vehicles[i] = new SUV();
                                else
                                    vehicles[i] = new Truck();
                                vehicles[i].RandomInit();
                            }

                            Console.WriteLine('\n' + "Созданный массив из машин: ");
                            for (int i = 0; i < vehicles.Length; i++)
                            {
                                vehicles[i].Show();
                                Console.WriteLine();
                            }
                            break;
                        }
                        case 2:
                        {
                            double avgSpeed = AverageSpeed(vehicles);
                            Console.WriteLine($"Средняя скорость легковых автомобилей: {avgSpeed} км/ч");
                            break;
                        }
                        case 3:
                        {
                            Vehicle MaxCost = FindMaxCost(vehicles);
                            Console.WriteLine($"Бренд самого дорогого внедорожника:{MaxCost.Brand}. Стоимость данной машины: {MaxCost.Price} рублей");
                            break;
                        }
                        case 4:
                        {
                            int sumPrice = SumCost(vehicles);
                            Console.WriteLine($"Сумма стоимости всех машин: {sumPrice} рублей");
                            break;
                        }
                        case 5:
                        {
                            FillArrayCars(cars);

                            break;
                        }
                        case 6:
                        {
                            int countCars = 0;
                            int countSUV = 0;
                            int countTruck = 0;

                            for (int i = 0; i < cars.Length; i++)
                            {
                                Console.WriteLine(cars[i]);
                                if (cars[i] is Car)
                                    countCars++;
                                else if (cars[i] is SUV)
                                    countSUV++;
                                else if (cars[i] is Truck)
                                    countTruck++;
                            }
                            Console.WriteLine($"Кол-во легковых машин = {countCars}");
                            Console.WriteLine($"Кол-во внедорожников = {countSUV}");
                            Console.WriteLine($"Кол-во грузовиков = {countTruck}");
                            break;
                        }
                        case 7:
                        {
                            Array.Sort(cars, new SortByPrice());
                            Console.WriteLine("Отсортированный массив по стоимости");
                            ShowArray(cars);
                            break;
                        }
                        case 8:
                        {
                            Vehicle p = new Vehicle();
                            cars[6] = p;
                            int pos = Array.BinarySearch(cars, p);
                            Console.WriteLine($"Позиция найденного объекта = {pos}");
                            break;
                        }
                        case 9:
                        {
                            Vehicle clonedVehicle = (Vehicle)vehicles[0].Clone();

                            Vehicle shallowCopy = vehicles[0].ShallowCopy();

                            Console.WriteLine("Cloned:");
                            clonedVehicle.Show();

                            Console.WriteLine("Shallow Copy:");
                            shallowCopy.Show();
                            break;
                        }
                        case 10:
                        {
                            Console.WriteLine("Завершение работы программы.");
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Неправильно задан пункт меню.");
                            break;
                        }
                }
            } while (answ != 10);
        }
    }  
}
