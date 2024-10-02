namespace time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            label1.Text = currentTime.ToString();
        }
    }
}
