using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Balance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Y Gopal\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");

        public void getBalance()
        {
            con.Open();
            string query = "select Balance from AccountTbl where AccNum='"+CurUser.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter( query , con );
            DataTable dt = new DataTable();
            sda.Fill( dt );
            CurUserBalance.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        public Balance()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Load(object sender, EventArgs e)
        {
            CurUser.Text = Login.CurAccNum;
            getBalance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            hOME.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
