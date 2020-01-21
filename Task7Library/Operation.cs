using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task7Library
{
    public class Operation
    {
        private string path = @"D:\Countries.txt";

        Dictionary<int, Country> listCountries = new Dictionary<int, Country>();

        public void ReadAndStoreCountries()
        {
            StreamReader streamReader = new StreamReader(path, Encoding.Default);
            string fileString = "";
            string[] values;
            int key = 1;

            while (fileString != null)
            {
                fileString = streamReader.ReadLine();

                if (fileString != null)
                {
                    values = fileString.Split(',');
                    listCountries.Add(key, new Country() { Name = values[0], IsTelenorSupported = Convert.ToBoolean(values[1]) });
                    key++;
                }
            }
            streamReader.Close();
        }

        public void AddCountry()
        {
            string countryName = "Ukraine";
            bool isTelenorSupported = false;
            StreamWriter streamWriter = new StreamWriter(path, true);

            listCountries.Add(listCountries.Count() + 1, new Country() { Name = countryName, IsTelenorSupported = isTelenorSupported });
            streamWriter.WriteLine(Environment.NewLine + countryName + "," + isTelenorSupported);
            streamWriter.Close();
        }

        public void ChangeCountry()
        {
            string firstCountryName = "Denmark";
            string secondCountryName = "Hungary";
            bool isTelenorSupported = true;
            StreamWriter streamWriter = new StreamWriter(path);

            foreach (Country country in listCountries.Values)
            {
                if (country.Name == firstCountryName || country.Name == secondCountryName)
                {
                    country.IsTelenorSupported = isTelenorSupported;
                }
                streamWriter.WriteLine(country.Name + "," + country.IsTelenorSupported);
            }
            streamWriter.Close();
        }

        public void PrintCountries()
        {
            foreach (Country country in listCountries.Values)
            {
                Console.Write(country);
            }
        }
    }
}
