using System;
using System.Collections;
using System.Collections.Generic;
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
            //Console.WriteLine(employee1);
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
            //Console.WriteLine(employee2);
            Console.WriteLine("=====================================================\n");
            
            Employee employee3 = new HourlyEmployee()
            {
                Id = 3030,
                FirstName = "Amaru",
                LastName = "Pinell",
                BirthDate = new Date(2008, 02, 26),
                HiringDate = new Date(2021, 09, 13),
                IsActive = true,
                Hours = 123.50F,
                HourValue = 12356.56M
            };
            //Console.WriteLine(employee3);
            Console.WriteLine("=====================================================\n");
            
            Employee employee4 = new BaseCommissionEmployee()
            {
                Id = 4040,
                FirstName = "Amaru",
                LastName = "Pinell",
                BirthDate = new Date(2008, 02, 26),
                HiringDate = new Date(2021, 09, 13),
                IsActive = true,
                Base = 860678.45M,
                CommissionPercentaje = 0.015F,
                Sales = 58000000M
            };
            //Console.WriteLine(employee4);

            ICollection<Employee> employees = new List<Employee>()
            {
                employee1, employee2, employee3, employee4 //Agregar nuevos empleados
            };

            decimal payroll = 0;

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                payroll += employee.GetValueToPay();
            }

            Console.WriteLine("                       ===============");
            Console.WriteLine($"TOTAL                  {$"{payroll:C2}",15}");

            Invoice invoice1 = new Invoice()
            {
                Description = "iPhone 13",
                Id = 1,
                Price = 5300000M,
                Quantity = 6
            };


            Invoice invoice2 = new Invoice()
            {
                Description = "Posta Premium",
                Id = 2,
                Price = 32000M,
                Quantity = 17.5F
            };

            Console.WriteLine(invoice1);
            Console.WriteLine(invoice2);
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
