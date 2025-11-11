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
    public partial class Form2 : Form
    {
        public delegate void del(int e);
        public event del Ev;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Ev != null)
            {
                Ev(int.Parse(textBox1.Text));
            }
            this.Close();
        }


    }
}
