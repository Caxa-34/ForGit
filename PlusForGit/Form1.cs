namespace PlusForGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            c = a + b;

            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            c = a - b;

            textBox3.Text = c.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            c = a * b;

            textBox3.Text = c.ToString();
        }
    }
}