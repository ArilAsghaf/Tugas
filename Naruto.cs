using System;

namespace Abstraction.Interface
{
    public class Naruto : IAnime
    {
        public void Cartoon()
        {
            Console.WriteLine("Naruto adalah sebuah serial anime jepang karya Masashi Kishimoto");
            Console.WriteLine("Bercerita tentang seorang ninja yang ingin mendapatkan gelar Hokage");
        }
    }
}
