# Debugging Challenge: Fix the Logic Bugs

## Objective

The student must:

* Identify and fix 3 specific logic errors.
* Predict and explain the original behavior before fixing.
* Run the fixed version and observe correct output.

---

## Broken Starter Code (With Bugs)

```csharp
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
```
