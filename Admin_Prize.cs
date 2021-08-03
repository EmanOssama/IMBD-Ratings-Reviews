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
    public partial class Admin_Prize : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott;Password=scott;";
        OracleConnection conn;
        public Admin_Prize()
        {
            InitializeComponent();
        }

        private void iconButton_back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.ShowDialog();
        }

        private void Admin_Prize_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetPrizeInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("prizetitle", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combobox_prize_title.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void Admin_Prize_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void combobox_prize_title_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "select * from prize";
            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                if (combobox_prize_title.Text == dr[0].ToString())
                {
                    textBox_prize_nationality.Text = dr[1].ToString();
                }
            }
            dr.Close();
        }

        private void btn_prize_add_Click(object sender, EventArgs e)
        {
            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;

            c1.CommandText = "insert_prize";
            c1.CommandType = CommandType.StoredProcedure;
            c1.Parameters.Add("prizetitle", combobox_prize_title.Text);
            c1.Parameters.Add("prizenationality", textBox_prize_nationality.Text);

            combobox_prize_title.Items.Add(combobox_prize_title.Text);
            c1.ExecuteNonQuery();

            MessageBox.Show("Prize is Added Successfuly!");
        }

        private void btn_prize_update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update PRIZE set NATIONALITY=:NATIONALITY where TITLE=:TITLE";
            cmd.Parameters.Add("NATIONALITY", textBox_prize_nationality.Text);
            cmd.Parameters.Add("TITLE", combobox_prize_title.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Prize is Updated Successfuly!");
            }
        }

        private void btn_prize_delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete PRIZE where TITLE=:TITLE";
            cmd.Parameters.Add("TITLE", combobox_prize_title.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Prize is Deleted Successfuly!");
            }
        }
    }
}
