namespace PaintBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog(this);
        }
    }
}