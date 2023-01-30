namespace FunctinalProgramingProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functinal Programing Problem");

            Console.WriteLine("Please enter below number");
            Console.WriteLine("1.FlipCoin \n 2.LeapYear \n 11.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoin.FindPercentageOfFlipCoin();
                    break;
                case 2:
                     LeapYear.FindLeapyear();
                    break;  
                default:
                    Console.WriteLine("please enter the option from above");
                break;
            }
            Console.ReadLine();
        }
    }
}