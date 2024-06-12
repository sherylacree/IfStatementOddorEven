using System.Diagnostics;

namespace IfStatement
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Enter an integer:");
                string answer = Console.ReadLine();


                int aNumber = Convert.ToInt32(answer);

                if (aNumber == 0)
                {
                    break;
                }
                if (aNumber % 2 == 0)
                {
                    Console.WriteLine($"{aNumber} is even.");
                }
                else { Console.WriteLine($"{aNumber} is odd."); }
            }



        }
    }
}


