
using System;
using System.Formats.Asn1;
using System.Net;

class Calculator 
{
        static double num1;
        static double num2;
        static double num3;
        static string math;
        static string answer="yes";
        static string userInput;
        static List<double> history=new List<double>();
        
    static public void Main()
    {

        Console.WriteLine("Hello welcome to DevDaf's Calculator");
        
       do{
        
        
        
        do
        {
            Console.WriteLine("Enter a number");
            userInput = Console.ReadLine();
            if (double.TryParse(userInput, out num1))
                {
                break;
                } 
            else
                {
                Console.WriteLine("You've not enterd a number please try again.");
                }

        }
        while(true);


         do
        {
            Console.WriteLine("Enter your second number");
            userInput = Console.ReadLine();
            if (double.TryParse(userInput, out num2))
                {
                break;
                } 
            else
                {
                Console.WriteLine("You've not enterd a number please try again.");
                }

        }
        while(true);

        Console.WriteLine("Please enter  the type of opertaion you want (+) (-) (*) (/)");
        math = Convert.ToString(Console.ReadLine());
        Console.WriteLine(math);

        if (math == "+")
        {
           num3 = num1 + num2;
            Console.WriteLine(num3);
        }
        
        else if (math == "-")
        {
            num3 = num1 - num2;
            Console.WriteLine(num3);
        }
        
        else if (math == "*")
        {
            num3 = num1 * num2;
            Console.WriteLine(num3);
        }
        else if (math == "/")
        {
            if(num2 == 0)
            {
                Console.WriteLine("Invalid input cannot divide by 0");
            }
            else
            {
            num3 = num1 / num2;
            Console.WriteLine(num3);
            }
        }
        else
        {
            Console.WriteLine("INVALID ENTRY PLEASE ENTER ONLY NUMBERS! AND OPERATORS!");
        }
                history.Add(num3);
                do
                {
                    Console.WriteLine("Do you want to see your previous results? Yes/No");
                    answer = Console.ReadLine();
                    if (answer == "yes")
                        {  
                            foreach (var history in history)
                            {
                                Console.WriteLine("Result : {0}", history);
                            }
                            break;
                        }

                    else if (answer == "no")
                        {
                            Console.WriteLine("Goodbye");
                            break;
                        }
                    else
                        {
                            Console.WriteLine("That is not a correct answer!");
                        }
                }
                while(true);
                Console.WriteLine("Do you want to continue?");
                answer = Console.ReadLine();
        } 
        while (answer.Equals("yes", StringComparison.InvariantCultureIgnoreCase));
        

    }
        
}
