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

            label1.Text = "";

            // 註冊 Application.Idle 事件，在應用閒置時更新 Label
            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            // 更新 Label 的文字為當前時間
            label1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
