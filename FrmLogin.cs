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

namespace School_Management
{
    public partial class FrmLogin : Form
    {
        string name { get; set; }
        string pass { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TextChange();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (GetLogin() != null)
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }

            else if (txtUsername.Text == "" | txtPassword.Text == "")
            {
                MessageBox.Show("Username or Password not given");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }

            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }

        }

        List<Login> GetLogin()
        {
            List<Login> lst = new List<Login>();

            SqlConnection con = new SqlConnection(clsConnection.connection);
            SqlCommand cmd = new SqlCommand("SP_GetLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = Convert.ToString(dr["Username"]);
                pass = Convert.ToString(dr["Password"]);
            }

            if (txtUsername.Text == name && txtPassword.Text == pass)
            {
                return lst;
            }

            return null;
        }

        public void TextChange()
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
