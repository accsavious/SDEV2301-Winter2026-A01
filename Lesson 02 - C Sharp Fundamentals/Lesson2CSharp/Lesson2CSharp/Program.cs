/* 
  USEFUL SHORTCUTS:

  Block Comment Shortcut: Ctrl + K, Ctrl + C
  Block Uncomment Shortcut: Ctrl + K, Ctrl + U
  Duplicate Line Shortcut: Ctrl + D
  Delete Line Shortcut: Ctrl + L
*/
DateTime nowTime = DateTime.Now;
int GetInt(int minimum, int maximum)
{
    bool success = false;
    int value = 0;
    while (!success)
    {
        success = int.TryParse(Console.ReadLine(), out value);
        if (!success || value < minimum || value > maximum)
        {
            Console.WriteLine($"Submit a whole number between {minimum} and {maximum}");
        }
    }
    return value;
}

DateTime date = new DateTime();
int year = 1990;
int month = 3;
int day = 12;

Console.WriteLine(3.0 % 1.0);

bool success = DateTime.TryParse($"{year}/{month}/{day}", out date);
if (success)
    Console.WriteLine(date);
else
    Console.WriteLine("conversion failed");

year = Int32.Parse(nowTime.ToString("yyyy"));
month = Int32.Parse(nowTime.ToString("MM"));
day = Int32.Parse(nowTime.ToString("dd"));
Console.WriteLine($"{year}");
System.Threading.Thread.Sleep(1000);
Console.WriteLine($"{month}");
System.Threading.Thread.Sleep(1000);
Console.WriteLine($"{day}");
System.Threading.Thread.Sleep(1000);
Console.WriteLine($"{DateTime.Now}");
System.Threading.Thread.Sleep(1000);
//const double EULERS_NUMBER = 2.71828;

//string name = "Jonathan Strange";
//int age = 40;
//double height = 2.01;
//bool isMagician = true;

//// string concatenation
//string cat = "Name: " + name + "\n" +
//             "Age: " + age + "\n" +
//             "Height: " + height + "\n" +
//             "Is Magician? " + isMagician;

//// string formatting
//string format = string.Format("Name: {0}\nAge: {1}\nHeight: {2}\nIs Magician? {3}",
//                               name, age, height, isMagician);

//// string interpolation
//string interpol = $"Name: {name}\nAge: {age}\nHeight: {height}\nIs Magician? {isMagician}";
//Console.WriteLine(interpol);

//Console.Write("Enter a spell to cast: ");
//string spell = Console.ReadLine();

//Console.Write($"How many times should {name} cast {spell}?");
//string numTimes = Console.ReadLine();



//// TryParse returns a boolen of whether the parsing was successful.
//// The "out" parameter will set the value of the variable passed into the function

//int casts;
//bool success = int.TryParse(numTimes, out casts);

//Console.WriteLine(casts);

//// MATH!!!!!!!!!!
//// +, -, *, /, %
//// +=, -=, *=, /=, %=

//double num = 5 / 2;
//Console.WriteLine(num);

//num = 5.0 / 2;
//Console.WriteLine(num);

////Force integer devision. Cast the numeric variable to an int first.
//double firstNum = 5.0;
//int intNum = (int)firstNum;

//////Ternary Operators
//Console.Write("Enter the first number: ");
//success = int.TryParse(Console.ReadLine(), out int num1);

//Console.Write("Enter the second number: ");
//success = int.TryParse(Console.ReadLine(), out int num2);

//string message;
//if (num1 * num2 > 100)
//    message = "Whoa that's a big number!";
//else
//    message = "Not that big of a number!";

//message = num1 * num2 > 100 ?
//                "Whoa that's a big number!" :
//                "Not that big of a number!";

//Console.WriteLine(message);

//double result = Math.Pow(2, 3); // evaluates to 8
//result = Math.Sqrt(9); // evaluate to 3
//result = Math.Round(1.3565); // evaluate to 1
//result = Math.Round(1.3565, 2); // evalute to 1.36


//// RANDOM NUMBERS

//// create a new "Random" object
//Random random = new Random();

//// Provide the lower bound (included in result) and the upper bound (not included)
//int number = random.Next(1, 21);

//Console.WriteLine(number);

//// Next Double will return a number from 0.0 (included) to 1.0 (not included)
//double dub = random.NextDouble();

//Console.WriteLine(dub);