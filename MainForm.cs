namespace Ethernal_Return_Match_Seacher
{
    public partial class MainForm : Form
    {
        public string Input_Text;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            Input_Text = Input_nick.Text;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            onClickCallback?.Invoke(Input_Text);
        }

    }
}
