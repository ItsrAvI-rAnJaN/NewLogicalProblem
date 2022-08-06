using BasicLogicalProgram;

Console.WriteLine("\t\t\t\t###################################################");
Console.WriteLine("\t\t\t\t\tWELCOME TO C# BASIC LOGICAL PROGRAM");
Console.WriteLine("\t\t\t\t###################################################");

int Choice;

do
{
    Console.WriteLine("\n0.Exit");
    Console.WriteLine("1.Fibonacci Series");
    Console.Write("\nPlease Enter Choice of Question Number : ");
    Choice=Convert.ToInt32(Console.ReadLine());

    switch (Choice)
    {
        case 1:
            Fibonacci.FibonacciSeries();
            break;
        default:
            Console.WriteLine("Please Enter Correct Question Number");
            break;
    }

}
while(Choice!=0);
Console.ReadKey();

//Fibonacci.FibonacciSeries();