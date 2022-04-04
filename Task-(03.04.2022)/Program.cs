using System;
using Task__03._04._2022_.Models;
using Task__03._04._2022_.Interfaces;
using System.Reflection;

namespace Task__03._04._2022_
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# => Interface,Reflection task...................
            Car car = new Car(4, "A4V6yugdghg87tu76", 2.5, 300, 2.2, 60, 35, "Dizel","Avtomatik",25.6);
            car.RemainOilAmount(5, 300);
            Console.WriteLine(car.AverageSpeed(15,56));
            car.ShowInfo();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Bicycle bicycle = new Bicycle("With the foot", 6, 12, 15, "Avtomatik");
            Console.WriteLine(bicycle.AverageSpeed(6,12));
            bicycle.ShowInfo();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Plane plane = new Plane(6.5, 3, 500, 35, 5, 300, 286, "Benzin");
            car.RemainOilAmount(300, 286);
            Console.WriteLine(plane.AverageSpeed(3,500));
            plane.ShowInfo();
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
    }
}
