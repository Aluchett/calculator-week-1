using System.Transactions;

namespace calculator2week1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Number: ");
            double firstN
           umber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Operator (+, -, /, *: ");
            string myOperator = Console.ReadLine();
            if (myOperator == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
             if (myOperator == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            if (myOperator == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);
                if (myOperator == "*").
                        }
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            if (myOperator == "*")
            {


            }
                Console.ReadLine();
            
            
        }
    }
}
