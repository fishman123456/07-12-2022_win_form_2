namespace _07_12_2022_win_form_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        void show(int b)
        {
            Random on = new Random();
            int games_rand = new Random().Next(1, 4);
            if (games_rand == b)
            {
                textBox1.Text = "WIN";
            }
            else
            {
                textBox1.Text = ($"Не WIN {b}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show(3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}