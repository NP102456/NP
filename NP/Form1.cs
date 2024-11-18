namespace NP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("เอ้า โอ้ย", "ออกเลยสาว", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Azure;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "มหาวิทยาลัยราชภัฎอุดรธานี")
            {
                label1.Text = "Udonthani Rajiabgat University";
            }
            else
            {
                label1.Text = "มหาวิทยาลัยราชภัฏอุดรธานี";
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.BurlyWood;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            label1.ForeColor = Color.FromArgb(r, g, b);
            //this.BackColor = Color.FromArgb(r, g, b);
            //this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
