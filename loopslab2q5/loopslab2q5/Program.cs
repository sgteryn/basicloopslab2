// See https://aka.ms/new-console-template for more information

int keyPadPin = 13579;

bool doorLocked = true;

int numberOfTries = 5;

int i = 0;

do
{
    Console.WriteLine("Enter the Key Code: ");
    int keyEntered = int.Parse(Console.ReadLine());

    i++;

    if (keyEntered == keyPadPin)
    {
        Console.WriteLine("Welcome, you may enter!");
        doorLocked = false;
        break;
    }
    else if (doorLocked == true && i == numberOfTries)
    {
        Console.WriteLine("Too Many incorrect attempts");
        break;
    }
    else
    {
        Console.WriteLine("Try again");
    }

} while (doorLocked == true && i < numberOfTries);

