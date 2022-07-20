// See https://aka.ms/new-console-template for more information
System.Text.StringBuilder sb = new System.Text.StringBuilder();
string s1 = "";
for(int i = 0; i < 50000; i++)
{
    s1 = s1 + "ABCDEFG";
}
Console.WriteLine("completed");

for(int i =0; i < 5000; i++)
{
    sb.Append("ABCDEFG");
}
Console.WriteLine("completed");