// See https://aka.ms/new-console-template for more information
superClass[] a = {
new subClassA(),
new subClassB(),
new subClassC()
};
Call(a);
static void Call(params superClass[] args)
{
    foreach (superClass o in args)
    {
        o.Disp();
    }
}

abstract class superClass
{
    abstract public void Disp();
}
class subClassA: superClass{
    public override void Disp()
    {
        Console.WriteLine("商品名はなに？");
    }
}
class subClassB : superClass
{
    public override void Disp()
    {
        Console.WriteLine("商品名は分からない");
    }
}
class subClassC : superClass
{
    public override void Disp()
    {
        Console.WriteLine("商品名がわかる");
    }
}

