using PatternFabric.Creators;
using System;

namespace PatternFabric
{
    class Program
    {
        static void Main(string[] args)
        {

            Blacksmith plateBlacksmith = new PlateBlacksmith();
            Armor plateArmor = plateBlacksmith.Create();            

            Blacksmith scalyBlacksmith = new ScalyBlacksmith();
            Armor scalyArmor = scalyBlacksmith.Create();

            Console.ReadKey();
        }
    }
}
