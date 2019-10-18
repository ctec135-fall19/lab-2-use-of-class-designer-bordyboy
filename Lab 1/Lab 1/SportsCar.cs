using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class SportsCar : Car
    {
        public string GetPetName()
        {
            PetName = "Praf";
            return PetName;
        }

        //prints PetName when called
        public void PrintName()
        {
            Console.WriteLine(GetPetName());
        }
    }
}
