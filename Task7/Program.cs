using System;
using System.Collections.Generic;
using Task7Library;

namespace Task7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();

            operation.ReadAndStoreCountries();

            var country = new Country();
            country.Name = "Ukraine";
            country.IsTelenorSupported = false;
            operation.AddCountry(country);

            List<Country> countriesToEdit = new List<Country>
            {
                new Country() { Name = "Denmark", IsTelenorSupported = true },
                new Country() { Name = "Hungary", IsTelenorSupported = true }
            };

            countriesToEdit.ForEach(c =>
            {
                operation.ChangeCountry(c);
            });

            operation.PrintCountries();

            Console.ReadKey();
        }
    }
}