using System;
using Abstraction.Interface;

namespace Abstractionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnime ianime;


            ianime = new OnePiece();
            ianime.Cartoon();

            Console.WriteLine();
            ianime = new Naruto();
            ianime.Cartoon();
            Console.ReadKey();
        }
    }
}
