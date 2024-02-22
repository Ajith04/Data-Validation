namespace Data_Validation
{
    public partial class frmloginpage : Form
    {
        public frmloginpage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmloginpage_Load(object sender, EventArgs e)
        {
            txtusername.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmregistrationpage registrationpage = new frmregistrationpage();
            registrationpage.Show();
            this.Hide();
        }
    }
}
