GenericTest<string> gen1 = new();
gen1.AddItem("一番目");
gen1.AddItem("二番目");
gen1[2] = "三番目";
// See https://aka.ms/new-console-template for more information
Console.WriteLine(gen1[0]);

Console.WriteLine(gen1[1]);
Console.WriteLine(gen1[2]);


GenericTest<DateTime> gen2 = new();
gen2.AddItem(DateTime.Now);
Console.WriteLine(gen2[0]);


class GenericTest<T>
{
    private T[] arr = new T[100];
    private int index;
    public void AddItem(T item)
    {
        arr[index++] = item;
    }
    public T this[int indx]
    {
        get => arr[index];
        set => arr[index] = value;
    }
}
