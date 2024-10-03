using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();


            Hello newFrm = new Hello();


            newFrm.TopLevel = false;


            newFrm.Show();


            splitContainer1.Panel2.Controls.Add(newFrm);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();


            Counter newFrm = new Counter();


            newFrm.TopLevel = false;


            newFrm.Show();


            splitContainer1.Panel2.Controls.Add(newFrm);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();


            Clock newFrm = new Clock();


            newFrm.TopLevel = false;


            newFrm.Show();


            splitContainer1.Panel2.Controls.Add(newFrm);
        }
    }
}
