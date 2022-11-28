using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      double myDouble = myint;
      Console.WriteLine(myint);
      Console.WriteLine(myDouble);
      Console.WriteLine("Hello World!");  
      string userName = Console.ReadLine();
      Console.WriteLine("UserName is "+userName);  
      //Operators
      int x = 100 + 50;
      int sum1 = 100 + 50;        // 150 (100 + 50)
      int sum2 = sum1 + 250;      // 400 (150 + 250)
      int sum3 = sum2 + sum2;     // 800 (400 + 400)
      //assignment
      int x = 10;
      x += 5;
      x -=3;
      x *=3;
      x /=3;
      x %=3;
      x &=3;
      x |=3;
      x ^=3;
      x >>=3;
      x <<=3;
      //Comparison
      x ==y;
      x != y;
      x > y;
      x < y;
      x >= y;
      x < 5 && x < 20;
      x<5 || x>5;
      !(x < 5 && x < 10);
      //Math
      Math.Max(5,10);
      Math.Min(5, 10);
      Math.Sqrt(64);
      Math.Abs(-4.7);
      Math.Round(9.99);
      // strings
      string greeting= "Hello";
      string greeting2 = "Nice to meet you!";
      string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      Console.WriteLine("The length of the txt string is: " + txt.Length);
      string txt = "Hello World";
      Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
      Console.WriteLine(txt.ToLower());   // Outputs "hello world"
      string x = "10";
      string y = "20";
      string z = x + y;  // z will be 1020 (a string)
      string firstName = "John";
      string lastName = "Doe";
      string name = $"My full name is: {firstName} {lastName}";
      Console.WriteLine(name);
      string myString = "Hello";
      Console.WriteLine(myString[0]);  // Outputs "H"
      string myString = "Hello";
      Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
      // \n	New Line
      // \t	Tab
      // \b	Backspace
      bool isCsharpFun = true;
      bool isFishTasty = false;
      Console.WriteLine(isCSharpFun);   // Outputs True
      Console.WriteLine(isFishTasty);   // Outputs False
      int x = 10;
      int y = 9;
      Console.WriteLine(x > y); // returns True, because 10 is higher than 9
      int x = 10;
      Console.WriteLine(x == 10); // returns True, because the value of x is equal to 10
      Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15
      // if (condition) 
        {
          // block of code to be executed if the condition is True
        }
        if (20 > 18) 
        {
          Console.WriteLine("20 is greater than 18");
        }
        int time = 20;
        if (time < 18) 
        {
          Console.WriteLine("Good day.");
        } 
        else 
        {
          Console.WriteLine("Good evening.");
        }
        // Outputs "Good evening."
        if (condition1)
        {
          // block of code to be executed if condition1 is True
        } 
        else if (condition2) 
        {
          // block of code to be executed if the condition1 is false and condition2 is True
        } 
        else
        {
          // block of code to be executed if the condition1 is false and condition2 is False
        }
        int time = 22;
        if (time < 10) 
        {
          Console.WriteLine("Good morning.");
        } 
        else if (time < 20) 
        {
          Console.WriteLine("Good day.");
        } 
        else 
        {
          Console.WriteLine("Good evening.");
        }
        // Outputs "Good evening."
        // Short if..else
        int time = 20;
        string result = (time < 18)? "Good day" : "HOolywood";
        COnsole.WriteLine(result);
        // switch
        switch(expression) 
          {
            case x:
              // code block
              break;
            case y:
              // code block
              break;
            default:
              // code block
              break;
          }
      int day = 4;
      switch (day) 
      {
        case 6:
          Console.WriteLine("Today is Saturday.");
          break;
        case 7:
          Console.WriteLine("Today is Sunday.");
          break;
        default:
          Console.WriteLine("Looking forward to the Weekend.");
          break;
      }
      // Outputs "Looking forward to the Weekend."
      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
      }
      // do while loop
      do
      {
        //code
      }
      while(condition);

      int i = 0;
      do 
      {
        Console.WriteLine(i);
        i++;
      }
      while (i < 5);
      // for loop
      for (int i=0;i < 5; i++)
      {
        Console.WriteLine(i);
      }
      for (int i = 0; i <= 10; i = i + 2) 
      {
        Console.WriteLine(i);
      }
      // foreach loop
      string[] cars = {"Volvo","BMW","ford","mazda"};
      foreach (string i in cars)
      {
        Console.WriteLine(i);
      }
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) 
        {
          break;
        }
        Console.WriteLine(i);
      }
      // arrays
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      int[] myNum = {10, 20, 30, 40};
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine(cars[0]);

      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      cars[0] = "Opel";
      Console.WriteLine(cars[0]);

      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine(cars.Length);
      // Outputs 4

      string[] cars = new string[4];
      // Declare an array
      string[] cars;

      // Add values, using new
      cars = new string[] {"Volvo", "BMW", "Ford"};

      // Add values without using new (this will cause an error)
      //cars = {"Volvo", "BMW", "Ford"};
      // Sort a string
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Array.Sort(cars);
      foreach (string i in cars)
      {
        Console.WriteLine(i);
      }

      //
      // Sort an int
      int[] myNumbers = {5, 1, 8, 9};
      Array.Sort(myNumbers);
      foreach (int i in myNumbers)
      {
        Console.WriteLine(i);
      }

      //Mulitidimensional arrays
      int[,] numbers = {{1,4,2},{3,6,4}};

      int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
      Console.WriteLine(numbers[0, 2]);  // Outputs 2

      int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
      numbers[0, 0] = 5;  // Change value to 5
      Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

      int[,] number ={{1,2,3},{4,6,1}};
      for (int i =0;i< numbers.GetLength(0);i ++)
      {
        for (int j = 0;j< numbers.GetLength(0);i++)
        {
          Console.WriteLine(number[i,j]);
        }
      }
    }
  }
}