using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Clock : Form
    {

        public Clock()
        {
            InitializeComponent();

            // 設置 Label 屬性
            label1.Text = "";

            // 初始化 Timer 並設置其屬性
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 設定為1000毫秒，即1秒
            timer1.Tick += timer1_Tick; // 設定當 Timer 每次觸發時調用的事件
            timer1.Start(); // 開始 Timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
