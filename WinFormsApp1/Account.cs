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

    public partial class Account : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Y Gopal\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");

        public Account()
        {
            InitializeComponent();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (AccNumTb.Text == "" || AccNameTb.Text == "" || AccFname.Text == "" || AddressTb.Text == "" || PhoneTb.Text == "" || PinTb.Text == "" || EducationCb.Text == "" || OccupationTb.Text == "" || DOBdate.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into AccountTbl values ('" + AccNumTb.Text + "','" + AccNameTb.Text + "','" + AccFname.Text + "','" + DOBdate.Text + "','" + PhoneTb.Text + "','" + AddressTb.Text + "','" + EducationCb.SelectedItem.ToString() + "','" + OccupationTb.Text + "','" + PinTb.Text + "','" + "0' )";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!! Logout and Login Again !");
                    con.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
