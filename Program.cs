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

            var animal4 = new TerrestrialAnimalV2();
            var animal5 = new TerrestrialAnimalV2();
            var animal6 = new TerrestrialAnimalV2();

            animal1.SayHi();
            animal1.Move();

            animal2.SayHi();
            animal2.Move();
            
            animal3.SayHi();
            animal3.Move();
            

            animal4.SayHi("Shark");
            animal4.Move(0);
            
            
            animal5.SayHi("Centipede");
            animal5.Move(100);

            animal6.SayHi("Eagle");
            animal6.Move(2);

        }
    }
}

