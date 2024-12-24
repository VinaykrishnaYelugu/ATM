using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Y Gopal\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");

        public static string CurAccNum;

        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "select count(*) from AccountTbl where AccNum='" + AccNumTb.Text + "' and PIN='" + PinTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                CurAccNum = AccNumTb.Text;
                //MessageBox.Show(AccNumTb.Text + "< -- >"+CurAccNum );
                HOME h = new HOME();
                h.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wring Account Number or PIN Code...");
            }

            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
