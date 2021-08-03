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
    public partial class Admin_Person : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott;Password=scott;";
        OracleConnection conn;
        public Admin_Person()
        {
            InitializeComponent();
            radioButton_user.Checked = true;
            radioButton_user.Enabled = false;
            radioButton_actor.Checked = false;
            radioButton_director.Checked = false;

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetUserName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Username", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combobox_id.Items.Add(dr[0].ToString());
            }
            dr.Close();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select * from prize";
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox_actor_director_prize.Items.Add(dr1[0].ToString());
            }
            dr1.Close();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select ID from movies";
            cmd2.CommandType = CommandType.Text;

            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_actor_movie_id.Items.Add(dr2[0].ToString());
            }
            dr2.Close();
        }

        private void Admin_Actor_Load(object sender, EventArgs e)
        {
            
        }

        private void Admin_Actor_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }
        string photo_path = "";
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                photo_path = ofd.FileName;
            }
        }

        private void label_movie_title_Click(object sender, EventArgs e)
        {

        }

        private void combobox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "select * from users";
            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                if (combobox_id.Text == dr[0].ToString())
                {
                    textBox_actor_FN.Text = dr[1].ToString();
                    textBox_actor_LN.Text = dr[2].ToString();
                    textBox_actor_BD.Text = dr[3].ToString();
                    textBox_actor_address.Text = dr[5].ToString();
                    textBox_actor_password.Text = dr[6].ToString();
                    textBox_actor_gender.Text = dr[7].ToString();
                    textBox_actor_userid.Text = dr[8].ToString();
                    pictureBox1.ImageLocation = dr[9].ToString();
                }
            }
            dr.Close();

            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;

            c1.CommandText = "select * from user_phone";
            c1.CommandType = CommandType.Text;
            OracleDataReader dr1 = c1.ExecuteReader();
            while(dr1.Read())
            {
                if (combobox_id.Text == dr1[0].ToString())
                {
                    textBox_actor_phone.Text = dr1[1].ToString();
                }
            }
            dr1.Close();

            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;

            c2.CommandText = "select * from USER_EMAIL";
            c2.CommandType = CommandType.Text;
            OracleDataReader dr2 = c2.ExecuteReader();
            while (dr2.Read())
            {
                if (combobox_id.Text == dr2[0].ToString())
                {
                    textBox_actor_email.Text = dr2[1].ToString();
                }
            }
            dr2.Close();

            bool actor = false;
            bool director = false;

            OracleCommand c3 = new OracleCommand();
            c3.Connection = conn;

            c3.CommandText = "select * from actor";
            c3.CommandType = CommandType.Text;
            OracleDataReader dr3 = c3.ExecuteReader();
            while (dr3.Read())
            {
                if (combobox_id.Text == dr3[1].ToString())
                {
                    actor = true;
                    textBox_directo_or_actor_rateid.Text = dr3[2].ToString();
                    break;
                }
            }
            dr3.Close();

            OracleCommand c4 = new OracleCommand();
            c4.Connection = conn;

            c4.CommandText = "select * from director";
            c4.CommandType = CommandType.Text;
            OracleDataReader dr4 = c4.ExecuteReader();
            while (dr4.Read())
            {
                if (combobox_id.Text == dr4[5].ToString())
                {
                    director = true;
                    textBox_directo_or_actor_rateid.Text = dr4[4].ToString();
                    break;
                }
            }
            dr4.Close();

            if (actor)
            {
                radioButton_actor.Checked = true;

                OracleCommand c5 = new OracleCommand();
                c5.Connection = conn;

                c5.CommandText = "select * from ACTOR_PRIZE";
                c5.CommandType = CommandType.Text;
                OracleDataReader dr5 = c5.ExecuteReader();
                while (dr5.Read())
                {
                    if (textBox_actor_userid.Text == dr5[0].ToString())
                    {
                        comboBox_actor_director_prize.Text = dr5[1].ToString();
                    }
                }
                dr5.Close();

                OracleCommand c51 = new OracleCommand();
                c51.Connection = conn;

                c51.CommandText = "select * from ACTED_IN";
                c51.CommandType = CommandType.Text;
                OracleDataReader dr51 = c51.ExecuteReader();
                while (dr51.Read())
                {
                    if (textBox_actor_userid.Text == dr51[0].ToString())
                    {
                        comboBox_actor_movie_id.Text = dr51[1].ToString();
                        textBox_actor_movie_character_name.Text = dr51[2].ToString();
                    }
                }
                dr51.Close();
            }
            else if (director)
            {
                radioButton_director.Checked = true;

                comboBox_actor_movie_id.Text = string.Empty;
                comboBox_actor_movie_id.Enabled = false;
                textBox_actor_movie_character_name.Text = string.Empty;
                textBox_actor_movie_character_name.Enabled = false;

                OracleCommand c6 = new OracleCommand();
                c6.Connection = conn;

                c6.CommandText = "select * from DIRECTOR_PRIZE";
                c6.CommandType = CommandType.Text;
                OracleDataReader dr6 = c6.ExecuteReader();
                while (dr6.Read())
                {
                    if (textBox_actor_userid.Text == dr6[0].ToString())
                    {
                        comboBox_actor_director_prize.Text = dr6[1].ToString();
                    }
                }
                dr6.Close();
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
       
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (textBox_actor_phone.Text == string.Empty)
            {
                MessageBox.Show("Please! Enter Required fields");
            }
            else if (textBox_actor_email.Text == string.Empty)
            {
                MessageBox.Show("Please! Enter Required fields");
            }
            else if (comboBox_actor_director_prize.Text== string.Empty)
            {
                MessageBox.Show("Please! Enter Required fields");
            }
            else
            {
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

                c1.CommandText = "insert_user";
                c1.CommandType = CommandType.StoredProcedure;
                c1.Parameters.Add("username", combobox_id.Text);
                c1.Parameters.Add("firstname", textBox_actor_FN.Text);
                c1.Parameters.Add("lastname", textBox_actor_LN.Text);
                c1.Parameters.Add("birthdate", textBox_actor_BD.Text);
                c1.Parameters.Add("address", textBox_actor_address.Text);
                c1.Parameters.Add("password", textBox_actor_password.Text);
                c1.Parameters.Add("gender", textBox_actor_gender.Text);
                c1.Parameters.Add("id", new_id);
                c1.Parameters.Add("userphoto", photo_path);
                c1.ExecuteNonQuery();
                combobox_id.Items.Add(combobox_id.Text);

                textBox_actor_userid.Text = new_id.ToString();
                

                OracleCommand c2 = new OracleCommand();
                c2.Connection = conn;

                c2.CommandText = "insert_user_phone";
                c2.CommandType = CommandType.StoredProcedure;
                c2.Parameters.Add("username", combobox_id.Text);
                c2.Parameters.Add("phone", Convert.ToInt32(textBox_actor_phone.Text));
                c2.ExecuteNonQuery();

                OracleCommand c3 = new OracleCommand();
                c3.Connection = conn;

                c3.CommandText = "insert_user_email";
                c3.CommandType = CommandType.StoredProcedure;
                c3.Parameters.Add("username", combobox_id.Text);
                c3.Parameters.Add("email", textBox_actor_email.Text);
                c3.ExecuteNonQuery();

                if (radioButton_actor.Checked == true)
                {
                    if (comboBox_actor_movie_id.Text == string.Empty)
                        {
                              MessageBox.Show("Please! Enter Required fields");
                        }
                    else if (textBox_actor_movie_character_name.Text == string.Empty)
                    {
                        MessageBox.Show("Please! Enter Required fields");
                    }

                    OracleCommand c4 = new OracleCommand();
                    c4.Connection = conn;
                    
                    c4.CommandText = "insert into actor values(:ID, :USER_NAME, :RATE_ID)";
                    c4.Parameters.Add("ID", textBox_actor_userid.Text);
                    c4.Parameters.Add("USER_NAME", combobox_id.Text);
                    c4.Parameters.Add("RATE_ID", textBox_directo_or_actor_rateid.Text);
                    c4.ExecuteNonQuery();

                    OracleCommand c41 = new OracleCommand();
                    c41.Connection = conn;

                    c41.CommandText = "insert into ACTOR_PRIZE values(:ACTOR_ID, :PRIZE_TITLE)";
                    c41.Parameters.Add("ACTOR_ID", textBox_actor_userid.Text);
                    c41.Parameters.Add("PRIZE_TITLE", comboBox_actor_director_prize.Text);
                    c41.ExecuteNonQuery();

                    OracleCommand c42 = new OracleCommand();
                    c42.Connection = conn;

                    c42.CommandText = "insert into ACTED_IN values(:ACTOR_ID, :MOVIE_ID, :A_CHARACTER)";
                    c42.Parameters.Add("ACTOR_ID", textBox_actor_userid.Text);
                    c42.Parameters.Add("MOVIE_ID", comboBox_actor_movie_id.Text);
                    c42.Parameters.Add("A_CHARACTER", textBox_actor_movie_character_name.Text);
                    c42.ExecuteNonQuery();
                    
                }
                else if (radioButton_director.Checked == true)
                {
                    if (comboBox_actor_movie_id.Text == string.Empty)
                    {
                        MessageBox.Show("Please! Enter Required fields");
                    }

                    OracleCommand c5 = new OracleCommand();
                    c5.Connection = conn;

                    c5.CommandText = "insert into director values(:ID, :FIRST_NAME, :LAST_NAME, :BIRTH_DATE, :RATE_ID, :USER_NAME)";
                    c5.Parameters.Add("ID", textBox_actor_userid.Text);
                    c5.Parameters.Add("FIRST_NAME", textBox_actor_FN.Text);
                    c5.Parameters.Add("LAST_NAME", textBox_actor_LN.Text);
                    c5.Parameters.Add("BIRTH_DATE", textBox_actor_BD.Text);
                    c5.Parameters.Add("RATE_ID", textBox_directo_or_actor_rateid.Text);
                    c5.Parameters.Add("USER_NAME", combobox_id.Text);
                    c5.ExecuteNonQuery();

                    OracleCommand c51 = new OracleCommand();
                    c51.Connection = conn;

                    c51.CommandText = "insert into DIRECTOR_PRIZE values(:DIRECTOR_ID, :PRIZE_TITLE)";
                    c51.Parameters.Add("DIRECTOR_ID", textBox_actor_userid.Text);
                    c51.Parameters.Add("PRIZE_TITLE", comboBox_actor_director_prize.Text);
                    c51.ExecuteNonQuery();

                    
                }

                MessageBox.Show("User Added Successfuly!");
                combobox_id.Text = string.Empty;
                textBox_actor_FN.Text = string.Empty;
                textBox_actor_LN.Text = string.Empty;
                textBox_actor_BD.Text = string.Empty;
                textBox_actor_phone.Text = string.Empty;
                textBox_actor_email.Text = string.Empty;
                textBox_actor_address.Text = string.Empty;
                textBox_actor_gender.Text = string.Empty;
                textBox_actor_userid.Text = string.Empty;
                textBox_actor_password.Text = string.Empty;
                textBox_directo_or_actor_rateid.Text = string.Empty;
                pictureBox1.Image = Image.FromFile(@"D:\FCIS_ASU     2021\3 Year 2019_2020\Semester 2\Database\Project\IMBD1\IMBD1\Resources\iconfinder_men_5925629.png");
                radioButton_user.Checked = false;
                radioButton_director.Checked = false;
                comboBox_actor_director_prize.Text = string.Empty;
                comboBox_actor_movie_id.Text = string.Empty;
                textBox_actor_movie_character_name.Text = string.Empty;
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;

            c1.CommandText = "update_user";
            c1.CommandType = CommandType.StoredProcedure;
            c1.Parameters.Add("username", combobox_id.Text);
            c1.Parameters.Add("firstname", textBox_actor_FN.Text);
            c1.Parameters.Add("lastname", textBox_actor_LN.Text);
            c1.Parameters.Add("birthdate", textBox_actor_BD.Text);
            c1.Parameters.Add("address", textBox_actor_address.Text);
            c1.Parameters.Add("password", textBox_actor_password.Text);
            c1.Parameters.Add("gender", textBox_actor_gender.Text);
            c1.Parameters.Add("userphoto", photo_path);
            c1.ExecuteNonQuery();

            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;

            c2.CommandText = "update_user_phone";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("username", combobox_id.Text);
            c2.Parameters.Add("phone", textBox_actor_phone.Text);
            c2.ExecuteNonQuery();

            OracleCommand c3 = new OracleCommand();
            c3.Connection = conn;

            c3.CommandText = "update_user_email";
            c3.CommandType = CommandType.StoredProcedure;
            c3.Parameters.Add("username", combobox_id.Text);
            c3.Parameters.Add("email", textBox_actor_email.Text);
            c3.ExecuteNonQuery();

            if (radioButton_actor.Checked == true)
            {
                OracleCommand c4 = new OracleCommand();
                c4.Connection = conn;

                c4.CommandText = "update_actor_actedin";
                c4.CommandType = CommandType.StoredProcedure;
                c4.Parameters.Add("actorid", textBox_actor_userid.Text);
                c4.Parameters.Add("movieid", comboBox_actor_movie_id.Text);
                c4.Parameters.Add("charactername", textBox_actor_movie_character_name.Text);
                c4.ExecuteNonQuery();
            }

            OracleCommand c5 = new OracleCommand();
            c5.Connection = conn;

            c5.CommandText = "update_actor_prize";
            c5.CommandType = CommandType.StoredProcedure;
            c5.Parameters.Add("actorid", textBox_actor_userid.Text);
            c5.Parameters.Add("prizetitle", comboBox_actor_director_prize.Text);
            c5.ExecuteNonQuery();

            OracleCommand c6 = new OracleCommand();
            c6.Connection = conn;

            c6.CommandText = "update_director_prize";
            c6.CommandType = CommandType.StoredProcedure;
            c6.Parameters.Add("directorid", textBox_actor_userid.Text);
            c6.Parameters.Add("prizetitle", comboBox_actor_director_prize.Text);
            c6.ExecuteNonQuery();

            MessageBox.Show("User is Updated Successfuly!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRateid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_director_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_actor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            OracleCommand c3 = new OracleCommand();
            c3.Connection = conn;

            c3.CommandText = "delete_user";
            c3.CommandType = CommandType.StoredProcedure;
            c3.Parameters.Add("username", combobox_id.Text);
            c3.ExecuteNonQuery();

            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;

            c1.CommandText = "delete_user_phone";
            c1.CommandType = CommandType.StoredProcedure;
            c1.Parameters.Add("username", combobox_id.Text);
            c1.ExecuteNonQuery();

            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;

            c2.CommandText = "delete_user_email";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("username", combobox_id.Text);
            c2.ExecuteNonQuery();

            MessageBox.Show("User is Deleted Successfuly!");
            combobox_id.Text = string.Empty;
            textBox_actor_FN.Text = string.Empty;
            textBox_actor_LN.Text = string.Empty;
            textBox_actor_BD.Text = string.Empty;
            textBox_actor_phone.Text = string.Empty;
            textBox_actor_email.Text = string.Empty;
            textBox_actor_address.Text = string.Empty;
            textBox_actor_gender.Text = string.Empty;
            textBox_actor_userid.Text = string.Empty;
            textBox_actor_password.Text = string.Empty;
            pictureBox1.Image = null;
            radioButton_user.Checked = false;
            radioButton_director.Checked = false;
            comboBox_actor_director_prize.Text = string.Empty;
            comboBox_actor_movie_id.Text = string.Empty;
            textBox_actor_movie_character_name.Text = string.Empty;
        }

        private void iconButton_back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.ShowDialog();
        }
    }
}
