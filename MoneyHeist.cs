using System;

namespace Abstraction.Abstractclass
{
    public class MoneyHeist : Film
    {
        public override void Story()
        {
            Console.WriteLine("Money Heist adalah film series yang bergenre crime, action, thriller");
            Console.WriteLine("Menceritakan tentang sekelompok orang yang mencoba untuk merampok bank.");
        }
    }
}