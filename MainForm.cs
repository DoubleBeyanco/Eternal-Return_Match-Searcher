using Ethernal_Return_Match_Searcher;

namespace Ethernal_Return_Match_Seacher
{
    public partial class MainForm : Form
    {
        public string Input_Text;
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            Input_Text = Input_nick.Text;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            onClickCallback?.Invoke(Input_Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onSearchCallback?.Invoke();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HelpBox hb = new HelpBox();

            hb.Show();
        }
    }
}
