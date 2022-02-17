using System;
using ConceptsPOO;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //LlamaClaseDate();
            Employee employee1 = new SalaryEmployee()
            {
                Id = 1010,
                FirstName = "Jorge",
                LastName = "Pinell",
                BirthDate = new Date(1975,07,10),
                HiringDate = new Date(2015, 05, 08),
                IsActive = true,
                Salary = 10256.25M
            };
            Console.WriteLine(employee1);
            Console.WriteLine("=====================================================\n");
            Employee employee2 = new CommissionEmployee()
            {
                Id = 2020,
                FirstName = "Katy",
                LastName = "Centeno",
                BirthDate = new Date(1984, 02, 27),
                HiringDate = new Date(2016, 07, 22),
                IsActive = true,
                CommissionPercentaje = 0.25F,
                Sales = 50000M
            };
            Console.WriteLine(employee2);
        }

        private static void LlamaClaseDate()
        {
            Console.WriteLine("POO Concepts");
            Console.WriteLine("===========s");

            try //Ctrl + ks
            {
                //Date date1 = new Date(2022, 02, 12);
                //Console.WriteLine(date1);
                Console.WriteLine(new Date(2022, 02, 28));
                Console.WriteLine(new Date(2024, 02, 29));
                Console.WriteLine(new Date(2023, 11, 29));
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

    }
}
