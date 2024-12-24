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
    public partial class MiniStatement : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Y Gopal\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");

        public MiniStatement()
        {
            InitializeComponent();
        }


        private void PopulateMethod()
        {
            con.Open();
            string query = "select * from TransactionTbl where AccNum='" + Login.CurAccNum + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MiniStatementDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            hOME.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiniStatement_Load(object sender, EventArgs e)
        {
            PopulateMethod();
        }
    }
}
