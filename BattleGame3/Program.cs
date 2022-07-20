// See https://aka.ms/new-console-template for more information
Console.WriteLine("モンスターたちがあらわれた");
Console.Write("お名前をどうぞ");

string? brave = Console.ReadLine();
string brave1 = brave + " の攻撃！";
string brave2 = brave + "はｘｘをとなえた";
string monster1 = "モンスターたちが帆ひるんでいる";
string monster2 = "モンスターたちが反撃した";
string monster3 = "モンスターたちは退散した";

Random rnd = new Random();

if (!string.IsNullOrEmpty(brave1))
{
    Console.WriteLine(brave1); 
    for (int i = 0; i < 10; i++)
    {
        System.Threading.Thread.Sleep(1000);
        int num = rnd.Next(0, 10);
        if(num <- 2)
        {
            Console.WriteLine(brave1);
        }
        else if (num >= 3 & num <= 5)
        {
            Console.WriteLine(brave2);
        }
        else if (num >= 6 & num <= 8)
        {
            Console.WriteLine(monster1);
        }
        else
        {
            Console.WriteLine(monster2);
        }
    }
    Console.WriteLine(monster3);
}

else
{
    Console.WriteLine("ゲーム終了");
}