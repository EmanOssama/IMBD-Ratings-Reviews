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
    public partial class Admin_Movies : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott;Password=scott;";
        OracleConnection conn;
        public Admin_Movies()
        {
            InitializeComponent();
        }

        private void Admin_Movies_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from movies";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combobox_id.Items.Add(dr[0]);
            }
            dr.Close();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select TITLE from PRIZE";
            cmd1.CommandType = CommandType.Text;

            OracleDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox_movie_prize.Items.Add(dr1[0].ToString());
            }
            dr1.Close();

            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "GetPrizeInfo";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("prizetitle", OracleDbType.RefCursor, ParameterDirection.Output);

            //OracleDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    combobox_prize_title.Items.Add(dr[0]);
            //}
            //dr.Close();
        }

        private void Admin_Movies_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        string poster_path = "";
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                poster_path = ofd.FileName;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_id.Text = string.Empty;
            textBox_movie_title.Text = string.Empty;
            textBox_movie_date.Text = string.Empty;
            textBox_movie_rate.Text = string.Empty;
            textBox_movie_language.Text = string.Empty;
            textBox_movie_directorid.Text = string.Empty;
            textBox_movie_numberofviews.Text = string.Empty;
            poster_path = string.Empty;
            textbox_movie_catrgory_id.Text = string.Empty;
            comboBox_movie_prize.Text = string.Empty;

            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "select * from movies";
            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
           while (dr.Read())
            {
               if(dr[0].ToString()==combobox_id.SelectedItem.ToString())
               {
                   textBox_movie_title.Text = dr[3].ToString();
                   textBox_movie_date.Text = dr[4].ToString();
                   textBox_movie_rate.Text = dr[6].ToString();
                   textBox_movie_language.Text = dr[2].ToString();
                   textBox_movie_directorid.Text = dr[7].ToString();
                   textBox_movie_numberofviews.Text = dr[1].ToString();
                   pictureBox1.ImageLocation = dr[5].ToString();
               }
            }
            dr.Close();

            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;

            c1.CommandText = "select * from MOVIE_CATEGORY";
            c1.CommandType = CommandType.Text;
            OracleDataReader dr1 = c1.ExecuteReader();
            while (dr1.Read())
            {
                if (dr1[0].ToString() == combobox_id.SelectedItem.ToString())
                {
                    textbox_movie_catrgory_id.Text = dr1[1].ToString();
                }
            }
            dr1.Close();

            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;

            c2.CommandText = "select * from MOVIE_PRIZE";
            c2.CommandType = CommandType.Text;
            OracleDataReader dr2 = c2.ExecuteReader();
            while (dr2.Read())
            {
                if (dr2[0].ToString() == combobox_id.SelectedItem.ToString())
                {
                    comboBox_movie_prize.Text = dr2[1].ToString();
                }
            }
            dr2.Close();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into movies values(:id,:number_of_views,:M_language,:title,:date_of_release,:movie_poster,:rate_id,:director_id)";
            cmd.Parameters.Add("id", combobox_id.Text);
            cmd.Parameters.Add("number_of_views", textBox_movie_numberofviews.Text);
            cmd.Parameters.Add("M_language", textBox_movie_language.Text);
            cmd.Parameters.Add("title", textBox_movie_title.Text);
            cmd.Parameters.Add("date_of_release", textBox_movie_date.Text);
            cmd.Parameters.Add("movie_poster", poster_path);
            cmd.Parameters.Add("rate_id", textBox_movie_rate.Text);
            cmd.Parameters.Add("director_id", textBox_movie_directorid.Text);
            int r = cmd.ExecuteNonQuery();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;

            cmd1.CommandText = "insert_movie_category";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("movie_id", combobox_id.Text);
            cmd1.Parameters.Add("category_id", textbox_movie_catrgory_id.Text);
            cmd1.ExecuteNonQuery();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            cmd2.CommandText = "insert_movie_prize";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("movie_id", combobox_id.Text);
            cmd2.Parameters.Add("prize_title", comboBox_movie_prize.Text);
            cmd2.ExecuteNonQuery();

            if (r != -1)
            {
                combobox_id.Items.Add(combobox_id.Text);
                MessageBox.Show("Movie Added Successfuly!");

                combobox_id.Text = string.Empty;
                textBox_movie_title.Text = string.Empty;
                textBox_movie_date.Text = string.Empty;
                textBox_movie_rate.Text = string.Empty;
                textBox_movie_language.Text = string.Empty;
                textBox_movie_directorid.Text = string.Empty;
                textBox_movie_numberofviews.Text = string.Empty;
                poster_path = string.Empty;
                textbox_movie_catrgory_id.Text = string.Empty;
                comboBox_movie_prize.Text = string.Empty;
                pictureBox1.ImageLocation = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "update movies set number_of_views=:number_of_views, M_language=:M_language, title=:title, date_of_release=:date_of_release, movie_poster=:movie_poster, rate_id=:rate_id, director_id=:director_id where ID=:id";
            cmd.Parameters.Add("number_of_views", textBox_movie_numberofviews.Text);
            cmd.Parameters.Add("M_language", textBox_movie_language.Text);
            cmd.Parameters.Add("title", textBox_movie_title.Text);
            cmd.Parameters.Add("date_of_release", textBox_movie_date.Text);
            cmd.Parameters.Add("movie_poster", poster_path);
            cmd.Parameters.Add("rate_id", textBox_movie_rate.Text);
            cmd.Parameters.Add("director_id", textBox_movie_directorid.Text);
            cmd.Parameters.Add("id", combobox_id.Text);
            int r = cmd.ExecuteNonQuery();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;

            cmd1.CommandText = "update MOVIE_CATEGORY set CATEGORY_ID=:CATEGORY_ID where MOVIE_ID=:id";
            cmd1.Parameters.Add("CATEGORY_ID", textbox_movie_catrgory_id.Text);
            cmd1.Parameters.Add("id", combobox_id.Text);
            cmd1.ExecuteNonQuery();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            cmd2.CommandText = "update movie_prize set PRIZE_TITLE=:PRIZE_TITLE where MOVIE_ID=:id";
            cmd2.Parameters.Add("PRIZE_TITLE", comboBox_movie_prize.Text);
            cmd2.Parameters.Add("id", combobox_id.Text);
            cmd2.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Movie Updated Successfuly!");

                combobox_id.Text = string.Empty;
                textBox_movie_title.Text = string.Empty;
                textBox_movie_date.Text = string.Empty;
                textBox_movie_rate.Text = string.Empty;
                textBox_movie_language.Text = string.Empty;
                textBox_movie_directorid.Text = string.Empty;
                textBox_movie_numberofviews.Text = string.Empty;
                textbox_movie_catrgory_id.Text = string.Empty;
                comboBox_movie_prize.Text = string.Empty;
                pictureBox1.ImageLocation = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from movie_prize where MOVIE_ID=:MOVIE_ID";
            cmd.Parameters.Add("MOVIE_ID", combobox_id.Text);
            cmd.ExecuteNonQuery();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "delete from MOVIE_CATEGORY where MOVIE_ID=:MOVIE_ID";
            cmd1.Parameters.Add("MOVIE_ID", combobox_id.Text);
            cmd1.ExecuteNonQuery();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "delete from movies where id=:id";
            cmd2.Parameters.Add("id", combobox_id.Text);
            int r = cmd2.ExecuteNonQuery();
            if (r != -1)
            {
                combobox_id.Items.Add(combobox_id.Text);
                MessageBox.Show("Movie deleted Successfuly!");

                combobox_id.Items.RemoveAt(combobox_id.SelectedIndex);
                combobox_id.SelectedItem = string.Empty;
                textBox_movie_numberofviews.Text = string.Empty;
                textBox_movie_language.Text = string.Empty;
                textBox_movie_title.Text = string.Empty;
                textBox_movie_date.Text = string.Empty;
                poster_path = string.Empty;
                textBox_movie_rate.Text = string.Empty;
                textBox_movie_directorid.Text = string.Empty;
                textbox_movie_catrgory_id.Text = string.Empty;
                comboBox_movie_prize.Text = string.Empty;
                pictureBox1.ImageLocation = string.Empty;
            }
        }

        private void iconButton_back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.ShowDialog();
        }
    }
}
