using System;
namespace SampleConApp{
    class Ex06ProgrammingConcepts
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("");
            do{
            System.Console.WriteLine("Enter  the first no");
            double first= double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the choice of the operations as +, -, * or / ");
            string operation = Console.ReadLine();

            System.Console.WriteLine("Enter  the second no");
            double second= double.Parse(Console.ReadLine());


            switch (operation)
            {
                case "+":
                    System.Console.WriteLine("The Added Value is {0}", (first + second));
                    break;
                 case "-":
                    System.Console.WriteLine("The Substract Value is {0}", (first - second));
                    break;
                 case "*":
                    System.Console.WriteLine("The Multiply Value is {0}", (first * second));
                    break;
                 case "/":
                    System.Console.WriteLine("The Divide Value is {0}", (first / second));
                    break;
                default:
                    System.Console.WriteLine("Invalid Choice of Operations");
                    break;
            }
        }while(true);
    }
}
}