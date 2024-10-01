
namespace MultiplicationProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to generate it's multiplication table: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication table for {userNumber}");

            Console.WriteLine();

            for (int interation = 1; interation <=10; interation++) 
            {

                int multiplicationResult = userNumber * interation;
                Console.WriteLine($"{userNumber} x {interation} = {multiplicationResult}");
            }
        }
    }
}
