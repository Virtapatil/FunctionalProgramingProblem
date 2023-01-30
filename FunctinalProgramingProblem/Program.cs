namespace FunctinalProgramingProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functinal Programing Problem");

            Console.WriteLine("Please enter below number");
            Console.WriteLine("1.FlipCoin \n2.LeapYear \n3.PowerOf2 \n4.HarmonicNumber \n6.QuotientAndRemainder \n7.SwapTwoNumber \n8.EvenOrOdd \n9.VowelOrConsonant \n10.LargestNumber \n 11.Exit");
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
                case 6:
                    QuotientAndRemainder.FindQuotientAndRemainder();
                    break;
                case 7:
                    SwapTwoNumbers.FindSwapTwoNumbers();
                    break;
                case 8:
                    EvenOrOdd.FindEvenOrOdd();
                    break;
                    case 9:
                        VowelOrConsonant.FindVowelOrConsonant();
                    break;
                    case 10:
                        LargestNumbers.FindLargestNumbers();
                    break;
                default:
                    Console.WriteLine("please enter the option from above");
                break;
            }
            Console.ReadLine();
        }
    }
}