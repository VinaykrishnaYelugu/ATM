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
using System.Collections;

namespace WinFormsApp1
{
    public partial class FastCash : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Y Gopal\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");

        public FastCash()
        {
            InitializeComponent();
        }

        int curbalance = 0;


        private void GetBalanceMethod()
        {
            string query = "select Balance from AccountTbl where AccNum='" + Login.CurAccNum + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            curbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            CurBalance.Text = dt.Rows[0][0].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WithDrawCash("100");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HOME h = new HOME();
            h.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            GetBalanceMethod();
        }

        private void WithDrawCash(string withdraw)
        {
            int withdraw_amt = Convert.ToInt32(withdraw);

            if (withdraw_amt > curbalance)
            {
                MessageBox.Show("Insufficient Balance !");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = "update AccountTbl set Balance = (Balance-'" + withdraw + "') where AccNum='" + Login.CurAccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Withdrawed!!");

                    HOME.RecordTransaction( con, "withdraw", Convert.ToInt32(withdraw) );
                    con.Close();

                    HOME h = new HOME();
                    h.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            WithDrawCash("500");
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            WithDrawCash("1000");
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            WithDrawCash("2000");
        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            WithDrawCash("5000");
        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            WithDrawCash("10000");
        }
    }
}
