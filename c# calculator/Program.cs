//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
try
{
    string choose;
    do
    {
        Console.WriteLine("Welcome to Multifunction calculator!");
        Console.WriteLine();
        Console.WriteLine("Choose your calculator type");
        Console.WriteLine();
        Console.WriteLine("1.Simple calculator");
        Console.WriteLine("2.Scientific calculator");
        Console.WriteLine();
        Console.WriteLine("Enter your choice:");
        int nm = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        if (nm == 1)
        {
            Console.WriteLine("You have selected the simple calculator");
            Console.WriteLine();
            Console.WriteLine("Choose operator for calculation?");
            Console.WriteLine(" 1.Addition(+)\n 2.Subtraction(-)\n 3.Multiplication(*)\n 4.Division(/)\n 5.Modulus(%)");
            Console.WriteLine();
            Console.WriteLine("Enter the number for operaton you want to perform:");
            int choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter numbers for calculations");
            Console.WriteLine();
            Console.WriteLine("Enter 1st number");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {n1 + n2}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {n1 - n2}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {n1 * n2}");
                    break;
                case 4:
                    if (n2 == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {n1 / n2}");
                    }
                    break;
                case 5:
                    Console.WriteLine($"Result: {n1 % n2}");
                    break;
                default:
                    Console.WriteLine("Sorry!! You entered wrong choice");
                    break;
            }
            Console.WriteLine();
        }



        if (nm == 2)
        {
            Console.WriteLine("You have selected the scientific calculator");
            Console.WriteLine();
            Console.WriteLine(" 1.Addition(+)\n 2.Subtraction(-)\n 3.Multiplication(*)\n 4.Division(/)\n" +
                " 5.Modulus(%)\n 6.Power(x^y)\n 7.square root(√)\n 8.Logarithm(log)\n 9.Pi(π)\n" +
                " 10.Sine(sin)\n 11.Cosine(cos)\n 12.Tangent(tan)");
            Console.WriteLine();
            Console.WriteLine("Enter number for operation you want to perform:");
            int ch = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter 1st number");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    double n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Result: {n1 + n2}");
                    break;
                case 2:
                    Console.WriteLine("Enter 1st number");
                    double n3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    double n4 = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Result: {n3 - n4}");
                    break;
                case 3:
                    Console.WriteLine("Enter 1st number");
                    double n5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    double n6 = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Result: {n5 * n6}");
                    break;
                case 4:
                    Console.WriteLine("Enter 1st number");
                    double n7 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    double n8 = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (n8 == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {n7 / n8}");
                    }
                    break;
                case 5:
                    Console.WriteLine("Enter 1st number");
                    double n9 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    double n10 = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Result: {n9 % n10}");
                    break;
                case 6:
                    Console.WriteLine("Enter base number");
                    double n11 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter exponent number");
                    double n12 = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Result: {Math.Pow(n11, n12)}");
                    break;
                case 7:
                    Console.WriteLine("Enter a square root number");
                    double n = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {Math.Sqrt(n)}");
                    break;
                case 8:
                    Console.WriteLine("Enter a number for log");
                    double ns = double.Parse(Console.ReadLine());
                    if (ns < 0)
                    {
                        Console.WriteLine("Sorry! Negative values does not exist");
                    }
                    else if (ns > 0) { 
                    Console.WriteLine($"Result: {Math.Log10(ns)}");
                         }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 9:
                    Console.WriteLine("Enter a pi number ");
                    double np = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {3.142 * np}");
                    break;
                case 10:
                    Console.WriteLine("Enter a sin number ");
                    double nsg = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {Math.Sin(nsg)}");
                    break;
                case 11:
                    Console.WriteLine("Enter a cos number ");
                    double nc = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {Math.Cos(nc)}");
                    break;
                case 12:
                    Console.WriteLine("Enter a tan number ");
                    double nt = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Result: {Math.Tan(nt)}");
                    break;
                default:
                    Console.WriteLine("Sorry!! you enetred number");
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Would you like to continue calcultion? Enter(yes/no)");
        choose = Console.ReadLine();
        Console.WriteLine();
    }
    while (choose.ToLower() == "yes");
}
catch(FormatException)
{
    Console.WriteLine("You made a mistake! Try again and follow the instruction! Please!");
}