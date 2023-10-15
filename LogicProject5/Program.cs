using System;

// Random random = new Random();
// int current = random.Next(1, 11);
/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/
// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

/*
int hero = 10;
int monster = 10;

while (hero > 0 && monster > 0)
{
    Random random1 = new Random();
    int current1 = random1.Next(1,11);
    monster -= current1;

    if (monster > 0)
    {
        Console.WriteLine($"The monster has lost {current1} health and has {monster} health remaining");
    }
    else 
    {
        Console.WriteLine("The monster has lost all its health! The hero has won!");
        break;
    }

    Random random2 = new Random();
    int current2 = random1.Next(1,11);
    hero -= current2;

    if (hero > 0)
    {
        Console.WriteLine($"The hero has lost {current2} health and has {hero} health remaining");
    }
    else 
    {
        Console.WriteLine("The hero has lost all of their health! The monster has won!");
    }
}
*/

string? readResult1;
bool validEntry1 = false;

Console.WriteLine("Enter a number between 5 and 10");

while(!validEntry1)
{
    readResult1 = Console.ReadLine();
    int numericValue = 0;
    bool validNumber;

    if(readResult1 != null)
    {
        validNumber = int.TryParse(readResult1, out numericValue);
        
        if(!validNumber)
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
        else
        {
            if(numericValue >= 5 && numericValue <= 10)
            {
                Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
                validEntry1 = true;
            }
            else 
            {
                Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            }
        }
    }
}


string? readResult2;
bool validEntry2 = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

while(!validEntry2)
{
    readResult2 = Console.ReadLine();
    if(readResult2 != null)
    {
        string testValue = readResult2.ToLower().Trim();

        switch(testValue)
        {
            case "administrator":
            Console.WriteLine($"Your input value (Administrator) has been accepted.");
            validEntry2 = true;
            break;

            case "manager":
            Console.WriteLine($"Your input value (Manager) has been accepted.");
            validEntry2 = true;
            break;

            case "user":
            Console.WriteLine($"Your input value (User) has been accepted.");
            validEntry2 = true;
            break;

            default:
            Console.WriteLine($"The role name that you entered, \"{readResult2}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            break;
        }
    }
}


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };


string myString = "";
foreach (string t in myStrings)
{
    int periodIndex = 0;
    string x = t;

    do
    {
        periodIndex = x.IndexOf(".");
        if(periodIndex != -1)
        {
            myString += x.Substring(0, periodIndex) + "\n";
            x = x.Remove(0, periodIndex + 1).TrimStart();
        }
        else 
        {
            myString += x + "\n";
            x = x.Remove(0);
        }
    } while(x.Length > 0);
}

Console.WriteLine(myString);
