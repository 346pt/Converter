namespace Converter12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;

            if (radioButton1.Checked == true)
            {
                a = Double.Parse(textBox1.Text);
                b = a * 0.45359237;
                textBox2.Text = Convert.ToString(b);
            }
            if (radioButton2.Checked == true)
            {
                a = Double.Parse(textBox1.Text);
                b = a * 45.359237;
                textBox2.Text = Convert.ToString(b);
            }
            if (radioButton3.Checked == true)
            {
                a = Double.Parse(textBox1.Text);
                b = a * 6.35029318;
                textBox2.Text = Convert.ToString(b);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}