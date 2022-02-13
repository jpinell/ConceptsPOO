using System;
using ConceptsPOO;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
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
