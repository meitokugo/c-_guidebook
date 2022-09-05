using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csちゃん
{
    internal class CSharpchan
    {
        private RandomResponder _res_random;

        private RepeatResponder _res_repeat;

        private Responder _responder;
        
        public string? Name { get; set; }

        public CSharpchan(string name)
        {
            Name = name;
            _res_random = new RandomResponder("Random");
            _res_repeat = new RepeatResponder("Repeat");
            _responder = new Responder("Responder");
        }
        public string Dialogue(string input)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 10);
            if(num<6)
            {
                _responder = _res_random;
            }
            else
            {
                _responder = _res_repeat;
            }
            return _responder.Response(input);
        }

        public string GetName()
        {
            return _responder.Name;
        }
    }

    class Responder
    {
        public string Name { get; set; }
        public Responder(string name)
        {
            Name = name;
        }

        public virtual string Response(String input)
        {
            return "";
        }
    }

    class RepeatResponder : Responder
    {
        public RepeatResponder(string name): base(name)
        {

        }

        public override string Response(string input)
        {
            return String.Format("{0}ってなに",input);
        }
    }
    class RandomResponder : Responder
    {
        private string[] _responses =
        {
            "めっちゃ寒い天気！",
            "確かにそうだね",
            "10円拾った",
            "じゃあこれ知ってる？",
            "それね",
            "それがかわいい"
        };
        public RandomResponder(string name) : base(name)
        {

        }
        public override string Response(string input)
        {
            Random rnd = new();
            return _responses[rnd.Next(0, _responses.Length)];
        }
    }
}
