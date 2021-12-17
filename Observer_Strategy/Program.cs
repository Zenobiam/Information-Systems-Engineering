using Laba._19._11.Model;
using System;

namespace Laba._19._11
{
    class Program
    {
        static void Main(string[] args)
        {
            var catholicChurch = new CatholicChurch();

            new Parishioner("Игорь", catholicChurch);
            new Parishioner("Елена", catholicChurch);
            new Normal("Максим", catholicChurch);

            catholicChurch.setNewsChurch("В продаже новые свечки");
            Console.ReadKey();
        }
    }
}