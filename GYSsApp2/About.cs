namespace GYSsApp2
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.github.com") { UseShellExecute = true });
        }
    }
}
