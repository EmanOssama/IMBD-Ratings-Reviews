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
    public partial class SignupForm : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott;Password=scott;";
        OracleConnection conn;
        public SignupForm()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }
        string userphoto = "";
        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "png|*.png";

            //DialogResult res = openFileDialog1.ShowDialog();
            //if (res == DialogResult.OK)
            //{
            //    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            //}
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                userphoto = ofd.FileName;
            }
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void SignupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_email.text == string.Empty || bunifuTextbox_user_phone.text == string.Empty || btn_password.text == string.Empty || btn_confirm_password.text == string.Empty || btn_user.text == string.Empty)
            {
                MessageBox.Show("Please! Enter Required Fields.");
            }
            if (btn_confirm_password.text != btn_password.text)
            {
                MessageBox.Show("Wrong Password!");
            }

            int max_id, new_id;
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "Get_Max_ID";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();
            try
            {
                max_id = Convert.ToInt32(c.Parameters["id"].Value.ToString());
                new_id = max_id + 1;
            }
            catch
            {
                new_id = 1;
            }
            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;
            string user = btn_user.text;
            string fn=btn_first_name.text;
            string ln=btn_last_name.text;
            string address = btn_address.text;
            string pass=btn_password.text;
            string g=btn_gender.text;
            string email = btn_email.text;
            string phone = bunifuTextbox_user_phone.text;

            c1.CommandText = "insert_user";
            c1.CommandType = CommandType.StoredProcedure;
            c1.Parameters.Add("u_name", user);
            c1.Parameters.Add("firstname", fn);
            c1.Parameters.Add("lastname", ln);
            c1.Parameters.Add("birthdate", bunifuDatepicker_user_birthdate.Value.ToString());
            c1.Parameters.Add("address", address);
            c1.Parameters.Add("password", pass);
            c1.Parameters.Add("gender", g);
            c1.Parameters.Add("id", new_id);
            c1.Parameters.Add("userphoto", userphoto);
            c1.ExecuteNonQuery();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "insert into USER_EMAIL values(:USER_NAME,:EMAIL)";
            cmd1.Parameters.Add("USER_NAME", user);
            cmd1.Parameters.Add("EMAIL", email);
            cmd1.ExecuteNonQuery();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "insert into USER_PHONE values(:USER_NAME,:PHONE)";
            cmd2.Parameters.Add("USER_NAME", user);
            cmd2.Parameters.Add("PHONE", phone);
            cmd2.ExecuteNonQuery();

            this.Hide();
            Form1 f = new Form1(userphoto);
            f.ShowDialog();
        }

        private void bunifuTextbox2_Enter(object sender, EventArgs e)
        {
            if (btn_first_name.text == "Ex: abc")
            {
                btn_first_name.text = string.Empty;
            }
        }

        private void btn_first_name_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btn_first_name_Leave(object sender, EventArgs e)
        {
            if (btn_first_name.text == string.Empty)
            {
                btn_first_name.text = "Ex: abc";
            }
        }

        private void btn_last_name_Enter(object sender, EventArgs e)
        {
            if (btn_last_name.text == "Ex: xyz")
            {
                btn_last_name.text = string.Empty;
            }
        }

        private void btn_last_name_Leave(object sender, EventArgs e)
        {
            if (btn_last_name.text == string.Empty)
            {
                btn_last_name.text = "Ex: xyz";
            }
        }

        private void btn_username_Enter(object sender, EventArgs e)
        {
            if (btn_user.text == "Ex: abc_xyz")
            {
                btn_user.text = string.Empty;
            }
        }

        private void btn_username_Leave(object sender, EventArgs e)
        {
            if (btn_user.text == string.Empty)
            {
                btn_user.text = "Ex: abc_xyz";
            }
        }

        private void btn_email_Enter(object sender, EventArgs e)
        {
            if (btn_email.text == "EX: Xyz_123@gmail.com")
            {
                btn_email.text = string.Empty;
            }
        }

        private void btn_email_Leave(object sender, EventArgs e)
        {
            if (btn_email.text == string.Empty)
            {
                btn_email.text = "EX: Xyz_123@gmail.com";
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

        private void btn_confirm_password_Enter(object sender, EventArgs e)
        {
            if (btn_confirm_password.text == "*********")
            {
                btn_confirm_password.text = string.Empty;
            }
            btn_confirm_password._TextBox.PasswordChar = '*';
        }

        private void btn_confirm_password_Leave(object sender, EventArgs e)
        {
            if (btn_confirm_password.text == string.Empty)
            {
                btn_confirm_password.text = "*********";
            }
        }

        private void btn_upload_MouseHover(object sender, EventArgs e)
        {
            btn_upload.ForeColor = Color.DarkSlateGray;
        }

        private void btn_upload_MouseLeave(object sender, EventArgs e)
        {
            btn_upload.ForeColor = Color.Black;
        }

        private void btn_signup_MouseHover(object sender, EventArgs e)
        {
            btn_signup.ForeColor = Color.DarkSlateGray;
        }

        private void btn_signup_MouseLeave(object sender, EventArgs e)
        {
            btn_signup.ForeColor = Color.Black;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuTextbox_user_phone.text == "Ex: 0123456789")
            {
                bunifuTextbox_user_phone.text = string.Empty;
            }
        }

        private void bunifuTextbox_user_phone_Leave(object sender, EventArgs e)
        {
            if (bunifuTextbox_user_phone.text == string.Empty)
            {
                bunifuTextbox_user_phone.text = "Ex: 0123456789";
            }
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btn_address_Enter(object sender, EventArgs e)
        {
            if (btn_address.text == "Ex: Street 1 City A")
            {
                btn_address.text = string.Empty;
            }
        }

        private void btn_address_Leave(object sender, EventArgs e)
        {
            if (btn_address.text == string.Empty)
            {
                btn_address.text = "Ex: Street 1 City A";
            }
        }

        private void btn_gender_Enter(object sender, EventArgs e)
        {
            if (btn_gender.text == "Ex: M-F")
            {
                btn_gender.text = string.Empty;
            }
        }

        private void btn_gender_Leave(object sender, EventArgs e)
        {
            if (btn_gender.text == string.Empty)
            {
                btn_gender.text = "Ex: M-F";
            }
        }
    }
}
