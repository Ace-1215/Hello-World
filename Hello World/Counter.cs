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

        private void Button1_Click(object sender, EventArgs e)
        {
            //i++;
            //label1.Text = i.ToString();
            //if (i == 10)
            //{
            //    MessageBox.Show("點到10停下");
            //}
            counter = 0; // 每次點擊按鈕時重置計數器
            timer1.Start(); // 開始計時

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 設置計時器每秒觸發
            timer1.Tick += Timer1_Tick; // 綁定計時器事件
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (counter <= 10)
            {
                label1.Text = counter.ToString(); // 更新Label顯示
                counter++;                        // 計數器遞增
            }
            else
            {
                timer1.Stop(); // 當計數到10時停止計時器
            }
        }
    }
}
