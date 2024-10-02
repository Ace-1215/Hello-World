using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Count_to_10
{
    public partial class Howtodemo : Form
    {
        public int i = 0;
        public Howtodemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            if (i == 10)
            {
                MessageBox.Show("點到10停下");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
