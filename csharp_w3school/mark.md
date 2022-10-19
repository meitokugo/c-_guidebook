使用const 可以在变量变成常量 不可更改且只读

常使用WriteLine()显示变量
C#可以一次声明同类型的多个变量
C#变量必须指定数据类型
隐式强制转换（自动） - 将较小的类型转换为较大的类型大小
char -> int -> long -> float -> double

打印Console.WriteLine()
输入Console.ReadLine()
cs_math    Max/Min/Sqrt/Abs/Round/

字符串插值 
string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);
My full name is: John Doe

访问字符串
string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"
特殊字符串
string txt = "We are the so-called \"Vikings\" from the north.";

call a Method

default parameter 
static void MyMethod(string country = "Norway") 
{
  Console.WriteLine(country);
}

return value
static int MyMethod(int x)
{
    return 5+X;
}

overloading
have the same name with different parameters:
int MyMethod(int x)
float MyMethod(float x)
double MyMethod(double x, double y)

C# Object-Oriented Programming.

create class
class car {
    string color = "red";

    static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
  }
}
Using Multiple Classes

prog2.cs
class Car 
{
  public string color = "red";
}

prog.cs
class Program
{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
    }
}

Constructors 特殊的方法
构造函数，在创建类的时候调用它，可用于设置字段的初始值

class Car {
    piblic string model; // Create a field

    // Create a class constructor for the Car class
    public Car()
    {
        model = "Mustang"; // Set the initial value for model
    }

    static void Main(string[] args)
    {
        Car Ford = new Car();
        conole.WriteLine(Ford.model); 
    }
}

how to access Modifiers
public string color;
public	The code is accessible for all classes
private	The code is only accessible within the same class

protected	The code is accessible within the same class, or in a class that is inherited from that class. 

Properties and Encapsulation属性和封装

class Person
{
   private string name; // field

   public string Name //property
   {
    get { return name;}
    set { name = value;}
   }
}

继承
possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

class Vehicle //base class(parent)
{
    public string brand = "Ford";
    public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car :Vehicle //derived class (child)
{
    public string modelName ="Mustang";
}

多态性
Polymorphism
Polymorphism means "many forms"

抽象
数据抽象是隐藏某些细节并仅向用户显示基本信息的过程。
抽象可以通过抽象类或接口来实现

keyword :Abstract

Abstract class    is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

Abstract method   can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).

abstract class Animal 
{
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("Zzzz");
    }
}

interfaces
实现抽象功能
interface is a completely abstract class

interface IAnimal 
{
  void animalSound(); // interface method (does not have a body)
  void run(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal
{
    public void animalSound()
    {
        Console.WriteLIne("The pig says ;wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();
        myPig.animalSound();
    }
}

枚举
Enums
enum Level 
{
  Low,
  Medium,
  High
}

File　Method
using System.IO;
File.SomeFileMethod();

AppendText()
Copy()
Create()
Delete()
Exits()
ReadAllText()
Replace()
WriteAllText()


C# try and catch
try
{
    //code block
}
catch (Exception e)
{
    handle errors
}