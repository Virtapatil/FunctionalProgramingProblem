namespace FunctinalProgramingProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functinal Programing Problem");

            Console.WriteLine("Please enter below number");
            Console.WriteLine("1.FlipCoin \n2.LeapYear \n3.PowerOf2 \n5.QuotientAndRemainder \n6.SwapTwoNumber \n 11.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoin.FindPercentageOfFlipCoin();
                    break;
                case 2:
                     LeapYear.FindLeapyear();
                    break;
                case 3:
                    PowerOf2.FindPowerOf2();
                    break;
                case 5:
                    QuotientAndRemainder.FindQuotientAndRemainder();
                    break;
                case 6:
                    SwapTwoNumbers.FindSwapTwoNumbers();
                    break;
                default:
                    Console.WriteLine("please enter the option from above");
                break;
            }
            Console.ReadLine();
        }
    }
}