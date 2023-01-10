using System.Runtime.CompilerServices;

//Extra
while (true)
{
    Console.WriteLine("Hello, Please enter your name:");
    string name = Console.ReadLine();

    //intro
    Console.WriteLine("Please enter a number between 1-100");
    int num = int.Parse(Console.ReadLine());

    //extra if statement
    if (num <= 0 || num >= 101)
    {
        Console.WriteLine(name + " " + num + " That was not between 1 and 100");
        break;
    }
    //if statements
    else if (num % 2 != 0 && num < 60)
    {
        Console.WriteLine(name + " " + num + " Odd and less than 60");
    }
    else if (num % 2 == 0 && num < 60)
    {
        Console.WriteLine(name + " " + num + " Even and less than 60");
    }
    else if (num % 2 == 0 && num > 26 && num <= 60)
    {
        Console.WriteLine(name + " " + num + " Even and between 26 and 60 inclusive");
    }
    else if (num % 2 == 0 && num > 60)
    {
        Console.WriteLine(name + " " + num + " Even and greater than 60");
    }
    else if (num % 2 != 0 && num > 60)
    {
        Console.WriteLine(name + " " + num + " Odd and greater than 60");
    }

    //Repeat or End
    Console.WriteLine("Would you like to continue? y/n");
    string userChoice = Console.ReadLine();

    if (userChoice == "n" || userChoice == "no")
    {
        Console.WriteLine("Goodbye");
        break;
    }
}