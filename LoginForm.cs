using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace IMBD1
{
    public partial class LoginForm : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott;Password=scott;";
        OracleConnection conn;

        public string userloginphoto = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from users";
            cmd.CommandType = CommandType.Text;

            bool found = false;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (btn_username.text == dr[4].ToString() && btn_password.text == "652012")
                {
                    found = true;
                    this.Hide();
                    Admin a = new Admin();
                    a.ShowDialog();
                    break;
                }
                else
                {
                    if (btn_username.text == dr[0].ToString() && btn_password.text == dr[6].ToString())
                    {
                        found = true;
                        userloginphoto = dr[9].ToString();
                        this.Hide();
                        Form1 f = new Form1(userloginphoto);
                        f.ShowDialog();
                        break;
                    }
                }
            }
            if (found == false)
            {
                MessageBox.Show("Invalid Username Or Password!");
                btn_username.text = string.Empty;
                btn_password.text = string.Empty;
            }
            dr.Close();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupForm s = new SignupForm();
            s.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            if(btn_username.text == "Ex: Xyz_123")
            {
                btn_username.text = string.Empty;
            }
        }

        private void btn_username_Leave(object sender, EventArgs e)
        {
            if (btn_username.text == string.Empty)
            {
                btn_username.text = "Ex: Xyz_123";
            }
        }

        private void btn_password_Enter(object sender, EventArgs e)
        {
            if (btn_password.text == "*********")
            {
                btn_password.text = string.Empty;
            }
            btn_password._TextBox.PasswordChar = '*';
        }

        private void btn_password_Leave(object sender, EventArgs e)
        {
            if (btn_password.text == string.Empty)
            {
                btn_password.text = "*********";
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btn_signin.ForeColor = Color.DarkSlateGray;
        }

        private void btn_signin_MouseLeave(object sender, EventArgs e)
        {
            btn_signin.ForeColor = Color.Black;
        }
    }
}
