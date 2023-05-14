using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace tpmodul12_1302213069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        } 


        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            string output = tandaBilangan.TandaBilangan(input);
            label1.Text = output;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}