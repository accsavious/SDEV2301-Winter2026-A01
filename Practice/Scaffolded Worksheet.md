This is the **scaffolded worksheet example** that matches the Lesson 3 objective: practicing conditional logic and loops by completing a simplified safety-check system using `if` and `while`.

---

# Scaffolded Worksheet: Insert Missing Conditions

## Scenario:

You’re working on a factory monitoring system. The system checks:

* If the emergency stop is active.
* If the temperature is safe. (90 degrees or lower)
* If a machine can continue running.

## Student Task:

Fill in the missing conditional expressions to complete the program logic.

---

## Starter Code (Scaffolded Version)

```csharp
bool emergencyStop = false;
int temperature = 85;
bool machineRunning = true;

if ( emergencyStop ) // ← Fill in condition to check emergency stop
{
    Console.WriteLine("System halted due to emergency stop!");
    machineRunning = false;
}

if ( temperature < 90 ) // ← Fill in condition to check if temperature is unsafe
{
    Console.WriteLine("Warning: Temperature too high!");
    machineRunning = false;
}

while ( machineRunning ) // ← Fill in condition to keep machine running
{
    Console.WriteLine("Machine is running safely...");
    temperature += 2; // simulate heat increase

    if (temperature > 90)
    {
        Console.WriteLine("Overheat detected!");
        machineRunning = false;
    }
}
```

---

## Sample Student Answers

```csharp
if (emergencyStop == true)
{
    Console.WriteLine("System halted due to emergency stop!");
    machineRunning = false;
}

if (temperature > 80)
{
    Console.WriteLine("Warning: Temperature too high!");
    machineRunning = false;
}

while (machineRunning == true)
{
    Console.WriteLine("Machine is running safely...");
    temperature += 2;

    if (temperature > 90)
    {
        Console.WriteLine("Overheat detected!");
        machineRunning = false;
    }
}
```

---

## Discussion Questions for Instructor

* How would the program behave if `machineRunning` wasn’t updated inside the loop?
* How can we make this safer using functions instead of all in `Main()`?
* What happens if the temperature is exactly 90?

---

