using System;
class Program 
{ static void Main(string[] args) 
    { 

        int a = 60;            /* 60 = 0011 1100 */            
        int b = 13;            /* 13 = 0000 1101 */        
        int c = 0;



        if (a == b) 

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
        c = a & b;         
        /* 12 = 0000 1100 */           
        Console.WriteLine("Line 1 - c 的值是 {0}", c); c = a | b;         
        /* 61 = 0011 1101 */         
        Console.WriteLine("Line 2 - c 的值是 {0}", c); c = a ^ b;   
        /* 49 = 0011 0001 */            
        Console.WriteLine("Line 3 - c 的值是 {0}", c); c = ~a;          
        /*-61 = 1100 0011 */           
        Console.WriteLine("Line 4 - c 的值是 {0}", c); c = a << 2;    
        /* 240 = 1111 0000 */            
        Console.WriteLine("Line 5 - c 的值是 {0}", c); c = a >> 2;  
        /* 15 = 0000 1111 */          
        Console.WriteLine("Line 6 - c 的值是 {0}", c); 
        Console.ReadLine();




    }
}


