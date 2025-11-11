using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public class CalculationComplete : EventArgs
        {
            public int Result = 0;
            public int Num1 = 0;
            public int Num2 = 0;

            public CalculationComplete(int result, int num1, int num2)
            {
                Result = result;
                Num1 = num1;
                Num2 = num2;
            }
        }

        public event EventHandler<CalculationComplete> ONCalculationComplete;  
 
        private void button1_Click(object sender, EventArgs e)
        {
            int Result = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            CalculationComplete calc = new CalculationComplete(Result, int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            if (ONCalculationComplete != null)
            {
                ONCalculationComplete(this, calc);
            }
        }
    }
}
