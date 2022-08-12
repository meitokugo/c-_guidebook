// See https://aka.ms/new-console-template for more information
Customer obj1 = new();
Customer obj2 = new("A101", "syuwadaro");
Customer obj3 = new("B101", "yamadachiro", 28);
Console.WriteLine(
    obj1.id + "" + obj1.name + "" + obj1.age);
Console.WriteLine(
    obj2.id + "" + obj2.name + "" + obj2.age);
Console.WriteLine(
    obj3.id + "" + obj3.name + "" + obj3.age);

Console.WriteLine("Hello, World!");
class Customer
{
    public string id;
    public string name;
    public int age;
    public Customer()
        :this("-","-",-1)
    {

    }
    public Customer(string id, string name)
    : this(id, name, -1)
    {

    }

    public Customer(string id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }

};


