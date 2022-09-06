SampleCls sc = new();
sc.Show();
// See https://aka.ms/new-console-template for more information
interface ISample
{
    void Show();
}
class SampleCls : ISample
{
    public void Show()
    {
        Console.WriteLine("SampleClsのShow()メソッドです");
    }
}
