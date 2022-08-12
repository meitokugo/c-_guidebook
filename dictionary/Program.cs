var dic = new Dictionary<string, string>();
dic.Add("わたし", "名詞");
dic.Add("は","助詞");
dic.Add("プログラム","名詞");
dic.Add("です","助動詞");
dic.Add("。","点");
var kList = new List<string>(dic.Keys);
var vList = new List<string>(dic.Values);
Console.WriteLine("[{0}]", string.Join(",", kList));
Console.WriteLine("[{0}]", string.Join(",", vList));
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
