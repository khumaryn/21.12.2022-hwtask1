using System;
using System.Collections.Generic;
using System.Text;

namespace _21._12._2022_hw
{
    internal class Car:Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;
        public int elave_benzin;
        // AddFuel() - parametr olaraq neçə litr benzin əlavə etmək istənildiyi daxil edilməlidir və capacity-ni aşmırsa əlavə edilməlidir


        public void Add()
        {
   
            if (elave_benzin + CurrentFuel < FuelCapacity)
            {
                Console.WriteLine("yol gedile biler");
            }
            else
            {

                Console.WriteLine("capacityni asir");
            }


        }
    }
}
