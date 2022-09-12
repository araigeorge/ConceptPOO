using System;

namespace ConceptPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concept!");
            Console.WriteLine("============");

            try
            {
                Console.WriteLine(new Date(2024, 2, 29));
                Console.WriteLine(new Date(2021, 12, 21));
                Console.WriteLine(new Date(2022, 11, 31));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }

        }
    }
}
