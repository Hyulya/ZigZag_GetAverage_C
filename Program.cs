// Write a C# Sharp program that takes four numbers as input to calculate and print the average.
//using System.Diagnostics.Metrics;

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the fourth number: 30

//Expected Output:
//The average of 10 , 15 , 20 , 30 is: 18
//Cheat: System.Math()

namespace GetAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the fourth number:");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());

            // decimal average = Queryable.Average(firstNumber, secondNumber, thirdNumber, fourthNumber);
            decimal average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            Console.WriteLine("The average of "+firstNumber+" ,"+ secondNumber + " ,"+ thirdNumber + " ,"+ fourthNumber+" is:"+average);
        }
    }
}
