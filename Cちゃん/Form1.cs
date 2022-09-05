namespace Cちゃん
{
    public partial class Form1 : Form
    {
        private int _num1, _num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmForm2 = new();
            frmForm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CheckValue())
                MessageBox.Show(Convert.ToString(_num1 - _num2));
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (CheckValue())
                MessageBox.Show(Convert.ToString(_num1 * _num2));
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (CheckValue())
                MessageBox.Show(Convert.ToString(_num1 / _num2));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CheckValue())
                MessageBox.Show(Convert.ToString(_num1 + _num2));
        }

    private bool CheckValue()
    {
        try
        {
            _num1 = Convert.ToInt32(textBox3.Text);
            _num2 = Convert.ToInt32(textBox4.Text);
            return true;
        }
        catch
        {
            MessageBox.Show("AとBに半角数字を入力してください。");
            return false;
        }
        finally
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox3.Focus();
        }
        }
    }
}