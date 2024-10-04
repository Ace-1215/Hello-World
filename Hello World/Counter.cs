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
    public partial class Counter : Form
    {
        private int counter = 0; // 計數變量
        public Counter()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            counter = 0; // 每次點擊按鈕時重置計數器
            await CountToTen();
        }
        private async Task CountToTen()
        {
            while (counter <= 10)
            {

                label1.Text = counter.ToString();
                counter++;
                await Task.Delay(1000);
            }
        }
    }
}
