using System;
using System.Windows.Forms;

namespace Csちゃん
{
    public partial class Form1 : Form
    {
        private CSharpchan _chan = new("C#ちゃん");

        public Form1()
        {
            InitializeComponent();
        }

        private void PutLog(String str)
        {
            textBox4.AppendText(str + "\r\n");
        }
        private string prompt()
        {
            return _chan.Name + ":" + _chan.GetName() + ">";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = textBox3.Text;
            if (string.IsNullOrEmpty(value))
            {
                label2.Text = "なに";
            }
            else
            {
                string response = _chan.Dialogue(value);
                label2.Text = response;
                PutLog(">" + value);
                PutLog(prompt() + response);
                textBox3.Clear();
            }
        }
    }
}