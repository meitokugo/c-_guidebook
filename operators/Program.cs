using System;
class Program 
{ static void Main(string[] args) 
    { int a = 21; int b = 10; if (a == b) 
        { Console.WriteLine("Line 1 - a 等于 b"); } 
        
        else 
        { Console.WriteLine("Line 1 - a 不等于 b"); } 
        if (a < b) 
        { Console.WriteLine("Line 2 - a 小于 b"); } 
        else 
        { Console.WriteLine("Line 2 - a 不小于 b"); }
        if (a > b) { Console.WriteLine("Line 3 - a 大于 b"); }
        else { Console.WriteLine("Line 3 - a 不大于 b"); } 
        /* 改变 a 和 b 的值 */      
        a = 5; b = 20; if (a <= b)
        { Console.WriteLine("Line 4 - a 小于或等于 b"); } 
        if (b >= a) 
        { Console.WriteLine("Line 5 - b 大于或等于 a"); } 
    } 
}


