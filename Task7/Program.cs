using System;
using Task7Library;

namespace Task7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();

            operation.ReadAndStoreCountries();
            operation.AddCountry();
            operation.ChangeCountry();
            operation.PrintCountries();

            Console.ReadKey();
        }
    }
}
