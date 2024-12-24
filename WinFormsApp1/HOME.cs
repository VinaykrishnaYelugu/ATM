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

namespace WinFormsApp1
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MiniStatement miniStatement = new MiniStatement();
            miniStatement.Show();
            this.Hide();
        }

        private void CurrentUser_Click(object sender, EventArgs e)
        {

        }

        private void HOME_Load(object sender, EventArgs e)
        {
            CurrentUser.Text = Login.CurAccNum;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit d = new Deposit();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change_Pin cp = new Change_Pin();
            cp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();
            w.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FastCash f = new FastCash();
            f.Show();
            this.Hide();
        }


        public static void RecordTransaction(SqlConnection con0, string type, int amount)
        {
            try
            {
                string query = "insert into TransactionTbl ( AccNum , Type , Amout, TDate ) values ('" + Login.CurAccNum + "','" + type + "','" + amount + "','" + DateTime.Today.ToString() + "' )";
                SqlCommand cmd = new SqlCommand(query, con0);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transaction Recorded !!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
