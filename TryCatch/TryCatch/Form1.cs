namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check1 = 0;
            int check2 = 0;
            int check3 = 0;
            if (checkBox1.Checked)
                check1 = 500;
            if (checkBox2.Checked)
                check2 = 1500;
            if (checkBox3.Checked)
                check3 = 2500;
            int total = check1 + check2�@+ check3;
            MessageBox.Show(
                "���z��" + total + "�ł�");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null)
                MessageBox.Show("���ڂ����I���ł�", "�G���[");
            else
                MessageBox.Show(
                    listBox1.SelectedItem.ToString(),
                    "�����Y�ꂸ��");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Insert(
                0,
                textBox1.Text);
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("�폜����ƍ��ڂ�I�����Ă��������B");
            }
            else
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }
    }
}