namespace Calculator
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
        int num1;
        int num2;
        int total;
        string opt;
        int result;


        private void button2_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            opt = "-";
            num1 = Convert.ToInt32(txttotal.Text);
            txttotal.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                opt = "+";
                num1 = Convert.ToInt32(txttotal.Text);
                txttotal.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEquual_Click(object sender, EventArgs e)
        {

            num2 = Convert.ToInt32(txttotal.Text);
            if (opt == ("+"))
                total = num1 + num2;
            if (opt == ("-"))
                total = num1 - num2;
            if (opt == ("*"))
                total = num1 * num2;
            if (opt == ("/"))
                total = num1 / num2;

            txttotal.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            opt = "*";
            num1 = Convert.ToInt32(txttotal.Text);
            txttotal.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            opt = "/";
            num1 = Convert.ToInt32(txttotal.Text);
            txttotal.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            total = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
