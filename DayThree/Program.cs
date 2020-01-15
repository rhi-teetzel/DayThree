using System;

namespace DayThree
{
    class Program
    {
        static void Main(string[] args)
          
        {
            int numberOfFriends = 2;
            int costPerPerson = 13;
            int totalBill = numberOfFriends * costPerPerson;

            if (totalBill >= 50) 
            {
                Console.WriteLine("Congratulations! You receive 10% off!");
            }
            else
            {
                Console.WriteLine("Congratulations! You receive 5% off!");               
            }
                Console.ReadKey();

            //end of program

        }
    }
}
