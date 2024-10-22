// See https://aka.ms/new-console-template for more information

//problem 1
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



//problem 2
//Prompt the user for a number.
Console.Write("Enter a Number: ");
int userNumber = int.Parse(Console.ReadLine());

//Use a for loop to output all the numbers from that number to 0.
for (int i = userNumber; i >= 0; i--)
{
    Console.WriteLine(i);
}
//After that loop finishes,use another loop to output all the numbers
//from 0 to that number.
for (int i = 0; i <= userNumber; i++)
{
    Console.WriteLine(i);
}



//Problem 3
//A door has a keypad entry. The combination to get in is 13579.
//Write a while loop that asks the user to enter a key code.
//The loop will repeat as long as the user enters the wrong code.
//After the user enters the correct code,
//the program will print out a welcome message.

int keyPadPin = 13579 ;

bool doorLocked = true;
int numberOfTries = 5;

for (int i = 0; i < numberOfTries; i++)
{

    while (doorLocked == true )
{
    Console.WriteLine("Enter the Key Code: ");
    int keyEntered = int.Parse(Console.ReadLine());
    if (keyEntered == keyPadPin)
    {
        Console.WriteLine("Welcome, you may enter!");
        break;
    }
    else if (doorLocked == true && i > numberOfTries)
       {
            Console.WriteLine("Try Again") ;
        }
   else 
    {
          Console.WriteLine("Too Many incorrect attempts")  ;
                break;
            }

        }
}


//Problem 4 - 3 continued
//Continue the previous exercise, but now add a limited number of tries, say 5.
//After 5 unsuccessful attempts, the loop ends, but instead of printing
//a welcome message, it prints a message warning that there were too many
//incorrect attempts.
//(But if the user entered the correct number,
//it will still print the welcome message as before.)
