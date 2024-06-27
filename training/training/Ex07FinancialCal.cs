using System;
namespace FinancialCalculatorApp{
    class FinancialCalculator{
        public double principal{get;set;}
        public double RateofIntrest{get;set;}
        public int Term {get; set;}

        public double CalculateEMI()
        {
            double monthrate= RateofIntrest /(12*100); // convert annual to monthly
            int totalmonths = Term * 12;

            double emi = (principal*monthrate* Math.Pow(1+monthrate,totalmonths)) / (Math.Pow(1+monthrate,totalmonths)-1);

            return emi;
        }
    }

    class RecurringDeposit{
        public double monthinstallment{get;set;}
        public double RateofIntrest{get;set;}
        public int Term {get; set;}

        public double calfinalamount(){
            double intrestpermonth=RateofIntrest/(12*100);
            double finalamount=0;

            finalamount= monthinstallment*((Math.Pow(1+intrestpermonth, Term) - 1) / intrestpermonth);

            return finalamount;
        }
        
    }

    class Ex07FinancialCal{
        static void Main(string[] args)
        {
            System.Console.WriteLine("Choose any one");
            System.Console.WriteLine("1. EMI CALCULATOR");
            System.Console.WriteLine("2. RD CALCULATOR");
            int choice=int.Parse(Console.ReadLine());

            switch(choice){
                case 1:
                    performemical();
                    break;
                case 2:
                    performrdcal();
                    break;
                default:
                    System.Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        static void performemical(){
            var cal=new FinancialCalculator();
            Console.WriteLine("Enter the Principal Amt");
            cal.principal= double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Rate of intrest");
            cal.RateofIntrest = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Term");
            cal.Term= int.Parse(Console.ReadLine());

            if(cal.Term < 3){
                System.Console.WriteLine("For car minimun term is 3 years and for house 10 years");
            }
            double emi = cal.CalculateEMI();
            Console.WriteLine("The result EMI is "+emi);
        }
        static void performrdcal(){
            var rd=new RecurringDeposit();
            Console.WriteLine("Enter montly installment");
            rd.monthinstallment= double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Rate of intrest");
            rd.RateofIntrest = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Term");
            rd.Term= int.Parse(Console.ReadLine());

            if(rd.Term < 3){
                System.Console.WriteLine("For car minimun term is 3 years and for house 10 years");
            }
            double finalamount = rd.calfinalamount();
            Console.WriteLine("The final amt is "+finalamount);
        }
    }   
}