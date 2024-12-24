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
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace WinFormsApp1
{
    public partial class Deposit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Y Gopal\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");


        public Deposit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (DepositAmtTb.Text == "" || Convert.ToInt32(DepositAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter Deposit Amount");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = "update AccountTbl set Balance = (Balance+'" + DepositAmtTb.Text + "') where AccNum='" + Login.CurAccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deposited Successfully !!");
                    HOME.RecordTransaction( con, "deposit", Convert.ToInt32(DepositAmtTb.Text));

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

        private void DepositAmtTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
