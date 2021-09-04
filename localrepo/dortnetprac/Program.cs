using System;
namespace CDCpractical
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalmilkproduced;
            int totalmilkcartoon;
            int costofonecartoon = 38, profitofonecartoon = 27;
            int totalcostofmilk;
            int profitsofmilk;
            Console.WriteLine("\n Enter the total volume of milk for today");
            totalmilkproduced = double.Parse(Console.ReadLine());
            totalmilkcartoon = (int)(totalmilkproduced / 3.78);
            totalcostofmilk = (int)(decimal.Round(totalmilkcartoon) * costofonecartoon);
            profitsofmilk = (int)(decimal.Round(totalmilkcartoon) * profitofonecartoon);
            Console.WriteLine("\n Per cartoon: 3.78L");
            Console.WriteLine("\n Total Milk :" + totalmilkproduced + 'l');
            Console.WriteLine("\n Number of cartoons of milk:" + totalmilkcartoon);
            Console.WriteLine("\n Cost of Milk for today:" + totalcostofmilk + " cents");
            Console.WriteLine("\n Profits obtained :" + profitsofmilk + " cents");

        }
    }
}
