using System;
using System.Runtime.ConstrainedExecution;

namespace _21._12._2022_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine("CurrentFuel i daxil et");
            int CurrentFuel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("FuelCapacity i daxil et");
            int FuelCapacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("elave_benzin i daxil et");
            int elave_benzin = Convert.ToInt32(Console.ReadLine());
           
            


            car1.elave_benzin = elave_benzin;
            car1.FuelCapacity = FuelCapacity;
            car1.CurrentFuel = CurrentFuel;
            car1.Add();
            
           





        }
    }
}
