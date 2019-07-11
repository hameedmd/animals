using System;

namespace animals_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new TerrestrialAnimalV1(4, "Lion");
            var animal2 = new TerrestrialAnimalV1(4, "Giraffe");
            var animal3 = new TerrestrialAnimalV1(2, "Meerkat");

            var animal4 = new TerrestrialAnimalV2(0, "Shark");
            var animal5 = new TerrestrialAnimalV2(100, "Centipede");
            var animal6 = new TerrestrialAnimalV2(2, "Eagle");

            animal1.SayHi(animal1.Name);
            animal1.Move(animal1.NumberOfLegs);
            

            animal2.SayHi(animal2.Name);
            animal2.Move(animal2.NumberOfLegs);
            
            animal3.SayHi(animal3.Name);
            animal3.Move(animal3.NumberOfLegs);
            

            animal4.SayHi(animal4.Name);
            animal4.Move(animal4.NumberOfLegs);
            
            
            animal5.SayHi(animal5.Name);
            animal5.Move(animal5.NumberOfLegs);

            animal6.SayHi(animal6.Name);
            animal6.Move(animal6.NumberOfLegs);

        }
    }
}
