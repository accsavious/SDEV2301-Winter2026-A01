# Out-of-Class Practice: EF Core Pokémon Entity

**Purpose:**
Reinforce how Entity Framework Core maps C# objects to database tables using SQLite.

This exercise is **practice only** and builds directly on Lesson 16.

---

## Rules for This Exercise

* Use `EnsureCreated()`
* If the model changes, delete the `.db` file and rerun the app

---

## Scenario

You are building a simple Pokémon tracking app.

Each Pokémon has:

* A unique ID (int)
* A name (string)
* A Pokémon type (string)
* A level (int)

---

## Step 1: Create the Pokémon Entity

Create a new Visual Studio solution.

Install the required Nuget Packages.

Create a new basic (automatic properties only) class named `Pokemon` with the above properties.

Notes:

* `Id` will become the primary key automatically
* No attributes or annotations are required

---

## Step 2: Create the DbContext
Add a new class that inherits from DbContext and overrides the OnConfiguring method to use SQLite.

Add a new `DbSet<Pokemon>` to your new DbContext class.

---

## Step 3: Reset the Database (if already created)

If you added a new entity:

1. Stop the application
2. Delete the SQLite database file (`app.db`)
3. Run the application again

This allows EF Core to recreate the database with the new table.

---

## Step 4: Insert Pokémon Records

Add at least **three Pokémon** to the database.

Example:

```csharp
context.Pokemons.Add(new Pokemon
{
    Name = "Pikachu",
    Type = "Electric",
    Level = 12
});

context.Pokemons.Add(new Pokemon
{
    Name = "Charmander",
    Type = "Fire",
    Level = 10
});

context.SaveChanges();
```

---

## Step 5: Query and Display Pokémon

Use LINQ to retrieve and display all Pokémon.

```csharp
var pokemons = context.Pokemons.ToList();

foreach (var p in pokemons)
{
    Console.WriteLine($"{p.Name} ({p.Type}) - Level {p.Level}");
}
```

---

## Optional Challenges (Not Required)

Try one or more of the following:

* Display only Pokémon above a certain level
* Sort Pokémon by level (highest first)
* Add a `CaughtDate` property
* Count how many Pokémon are in the database
* Add a new class called `GymLeader` with the properties
    * Id (int)
    * Name (string)
    * Town (string)
    * Type (string)
* Add some `GymLeader` objects to the database.
* Sort gym leaders by Type, then by Name.
* Display all gym leaders
---

## Reflection (Optional but Recommended)

Answer these questions for yourself:

* What caused the database file to be created?
* What happened when you deleted the `.db` file?
* How did EF Core know how to create the Pokémon table?
* What role did `DbSet<Pokemon>` play?

---

## Key Takeaway

> EF Core lets you work with database data using **C# objects**,
> and SQLite simply stores that data in a file.

You are learning EF Core — not database administration.


