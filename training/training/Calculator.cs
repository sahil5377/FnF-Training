using System;
namespace SampleConApp{
    class Ex06ProgrammingConcepts
    {
        static double PerformOperations(double first,double second, string operation){
            switch (operation)
            {
                case "+":
                    return(first + second);
                case "-":
                    return(first - second);
                case "*":
                    return(first * second);
                case "/":
                    return(first / second);
                default:
                    return 0;
            }
        }
        static void Main(string[] args){
        do{
            System.Console.WriteLine("Enter  the first no");
            double first= double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the choice of the operations as +, -, * or / ");
            string operation = Console.ReadLine();

            System.Console.WriteLine("Enter  the second no");
            double second= double.Parse(Console.ReadLine());
            
            double result = PerformOperations(first,second,operation);
            System.Console.WriteLine("The result of this operations is "+result);
        }while (true);
    }
    }
}
