using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Withdraw : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Y Gopal\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");

        public Withdraw()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME h = new HOME();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "select Balance from AccountTbl where AccNum='" + Login.CurAccNum + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            
            if (WithdrawalTb.Text == "" || Convert.ToInt32(WithdrawalTb.Text) <= 0)
            {
                MessageBox.Show("Enter Deposit Amount");
            }
            else
            {
                int cur_balance = Convert.ToInt32(dt.Rows[0][0].ToString());
                int withdraw = Convert.ToInt32(WithdrawalTb.Text);

                if( withdraw>cur_balance )
                {
                    MessageBox.Show("Insufficient Balance !");
                }
                else
                {
                    try
                    {
                        con.Open();

                        query = "update AccountTbl set Balance = (Balance-'" + WithdrawalTb.Text + "') where AccNum='" + Login.CurAccNum + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successfully Withdrawed!!");

                
                        HOME.RecordTransaction( con , "withdraw" , Convert.ToInt32( WithdrawalTb.Text )  );
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

        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
