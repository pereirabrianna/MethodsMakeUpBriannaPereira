using System;

namespace MethodsMakeUpBriannaPereira
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Brianna Pereira Version = 36");

                Console.WriteLine("Please enter any string: ");

                string x = Console.ReadLine();


                Console.WriteLine("Please enter a number between 3 and 6: ");


                int y = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine("Please enter a single character: ");

                char seperator = Convert.ToChar(Console.ReadLine());

                if (y > 2 && y < 7)
                {
                    CopiesOfString(x, y, seperator);
                }
                else
                {
                    Console.WriteLine("Please retry and enter a value between 3 and 6!");
                    
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static string CopiesOfString(string input, int repeat, char seperate)
        {
            for(int i=0; i <= repeat; i++)
            {
                if (i == repeat)
                {
                    Console.Write(input);
                }
                else
                {
                    Console.Write(input + seperate);
                }
                
            }

            return input;
        }
    }
}
