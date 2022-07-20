namespace pickable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) MessageBox.Show(
                "checking",
                "right");
            else MessageBox.Show(
                " notchecking",
                "false");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="")
            {
                MessageBox.Show("input money");
            }
            else
            {
                string caption = "どっちが選ぼう";
                int pocket = Convert.ToInt32(textBox1.Text);
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result1;
                DialogResult result2;

                string message1 = "甘いのにする？";
                string message2 = "カロリーは気になる";

                if (pocket <300)
                {
                    label2.Text = "「カリカリシュークリーム」一択だ";
                }
                else
                {
                    result1 = MessageBox.Show(message1, caption, buttons);
                    result2 = MessageBox.Show(message2, caption, buttons);
                    if(result1 == DialogResult.Yes & result2 == DialogResult.Yes)
                    {
                        label2.Text = "「ぶるぶるコーヒーゼリー」にしましょう";
                    }
                    else if(result1 == DialogResult.Yes & result2 == DialogResult.No)
                    {
                        label2.Text = "「ｘｘｘｘ」にしましょう";
                    }
                    else if (result1 == DialogResult.No & result2 == DialogResult.Yes)
                    {
                        label2.Text = "「プロテイン」だね";
                    }
                    else
                    {
                        label2.Text = "ビタンカカオエクレアにしましょう";
                    }
                }
            }
        }
    }
}