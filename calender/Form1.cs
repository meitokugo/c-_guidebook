namespace calender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "選択した日付" + dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");
            int birthday = dateTimePicker1.Value.Subtract(DateTime.Today).Days;
            label3.Text = "本日から次の誕生日まであと" + birthday.ToString() + "日";
        }
    }
}