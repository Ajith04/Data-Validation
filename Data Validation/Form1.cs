using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Data_Validation
{
    public partial class frmloginpage : Form
    {
        public frmloginpage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GHFGR6A\SQLEXPRESS;Initial Catalog=""Data Validation"";Integrated Security=True;Encrypt=False");

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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select [User Name], [Password] from [User Details] where [User Name]=@username and [Password]=@password", con);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);

            SqlDataReader da = cmd.ExecuteReader();

            if (da.Read())
            {
                frmhomepage homepage = new frmhomepage();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error");
            }
            con.Close();
        }
    }
}
