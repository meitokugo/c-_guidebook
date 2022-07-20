// See https://aka.ms/new-console-template for more information
Console.WriteLine("お名前をどうぞ＞＞");
string? brave = Console.ReadLine();

if (!string.IsNullOrEmpty(brave))
{
    for (int i = 0;
        i < 5;
        i++
        )
    {
        Console.WriteLine(brave + "attack");
    }
    Console.WriteLine("monnsuta-tachihataisannshita");
}
else
    Console.WriteLine("ゲーム終了");
