using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the program");
            Console.WriteLine("\n 1. Fibonacci Series \n 2. Perfect Number \n 3. Prime Number \n 4. Reverse Number \n 5. Coupon Numbers \n 6. Simulate Stop Watch" +
                "\n 7. Notes Vending Machine \n 8. Day of Week \n 9. Temperature Conversion \n 10. Monthly Payment \n 11. Sqrt \n 12. To Binary \n 13. Swap Nibbles");
            int programNum = Convert.ToInt32(Console.ReadLine());
            switch (programNum)
            {
                case 1:
                    FibonacciSeries.GetFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNumber.GetPrimeNumbers();
                    break;
                case 4:
                    ReverseNumber.GetReverseNumber();
                    break;
                case 5:
                    CouponNumbers.CheckCouponNumbers();
                    break;
                case 6:
                    SimulateStopWatch.GetElapsedTime();
                    break;
                case 7:
                    NotesVendingMachine.GetNotes();
                    break;
                case 8:
                    DayOfWeek.FindDayOfWeek();
                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                case 12:

                    break;
                case 13:
                default:
                    Console.WriteLine("Please choose the correct ProgramNum");
                    break;
            }
        }
    }
}
