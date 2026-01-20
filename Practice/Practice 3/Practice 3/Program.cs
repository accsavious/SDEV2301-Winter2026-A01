int attempts = 0;
bool success = false;
string password = "OpenSesame";

while (success == false) // Bug 1: Potential infinite loop
{
    Console.WriteLine("Enter the password:");
    string input = Console.ReadLine();

    if (input == password)
        success = true;
    Console.WriteLine("Access granted."); // Bug 2: Missing else block causes this to always run

    if (attempts > 5) // Bug 3: Incorrect condition (runs too late)
    {
        Console.WriteLine("Too many attempts. Locked out.");
        break;
    }

    attempts++;
}