namespace Delegates
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

        private void userControl11_ONCalculationComplete(object sender, Delegates.UserControl1.CalculationComplete e)
        {
            MessageBox.Show("Num1 = " + e.Num1 + " Num2 = " + e.Num2 + " Result = " + e.Result);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Ev += Metho;
            frm.ShowDialog();
        }

        private void Metho(int e)
        {
            guna2TextBox1.Text = e.ToString();
        }

    }
}
