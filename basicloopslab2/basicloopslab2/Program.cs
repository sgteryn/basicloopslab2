// See https://aka.ms/new-console-template for more information

//Use a do-while loop to output "Hello, World!" in a loop.
//Each time you output "Hello, World!" ask the user whether
//they would like to continue.

Console.WriteLine("Hello, World!");
bool continueHelloWorldProgram = true;


do
{
        Console.WriteLine("Would you like to continue? (y/n)");
        string continueHelloWorld = Console.ReadLine();

    if (continueHelloWorld.ToLower() == "n")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else if (continueHelloWorld.ToLower() == "y")
    {
        Console.WriteLine("Hello, World!");
    }else
    {
        Console.WriteLine("Please Enter a valid Response");
    }

} while (continueHelloWorldProgram == true);

//Prompt the user for a number.
Console.Write("Enter a Number");
//Use a for loop to output all the numbers from that number to 0.
//After that loop finishes,use another loop to output all the numbers
//from 0 to that number.




