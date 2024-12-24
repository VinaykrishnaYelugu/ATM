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
    public partial class Change_Pin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Y Gopal\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");

        public Change_Pin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewPinTb.Text == "" || ConfirmPinTb.Text == "")
            {
                MessageBox.Show("Enter PIN VALUES");
            }
            else if (NewPinTb.Text != ConfirmPinTb.Text)
            {
                MessageBox.Show("New and Confirming Pins are not matching..");
            }
            else
            {
                try
                {
                    con.Open();

                    string query = "update AccountTbl set PIN = '" + ConfirmPinTb.Text + "' where AccNum='" + Login.CurAccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("PIN CHANGED SUCCESSFULLY !!");

                    con.Close();

                    Login L = new Login();
                    L.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Change_Pin_Load(object sender, EventArgs e)
        {

        }
    }
}
