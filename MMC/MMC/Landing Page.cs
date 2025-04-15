namespace MMC
{
    public partial class MMC : Form
    {
        public MMC()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
