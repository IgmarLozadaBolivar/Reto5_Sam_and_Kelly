using System;
namespace Reto5
{
    class NumberMinOfDays
    {
        static void Main()
        {
            Console.Write("Ingresa el numero de dias de problemas resultos de SAM: ");
            int samDaily = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el numero de dias de problemas resultos de KELLY: ");
            int kellyDaily = int.Parse(Console.ReadLine());

            int difference;
            difference = samDaily - kellyDaily;

            int result = MinNum(samDaily, kellyDaily, difference);
            Console.WriteLine($"Numero minimo de dias para que Kelly supere a Samm: {difference}");
            Console.WriteLine($"Numero minimo de dias diferente: {result}");
            Console.WriteLine($"SamDaily = {samDaily}, KellyDaily = {kellyDaily}, DifferenceOfDays = {difference}");
        }

        static int MinNum(int SamDaily, int KellyDaily, int difference)
        {
            if (SamDaily >= KellyDaily)
            {
                return -1;
            }

            int days = 0;
            int samSolved = difference;
            int kellySolved = 0;

            while (kellySolved <= samSolved)
            {
                samSolved += SamDaily;
                kellySolved += KellyDaily;
                days++;
            }

            return days;
        }
    }
}