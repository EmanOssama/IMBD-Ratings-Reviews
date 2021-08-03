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
    public partial class Admin_Categories : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott;Password=scott;";
        OracleConnection conn;
        public Admin_Categories()
        {
            InitializeComponent();
        }

        private void iconButton_back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.ShowDialog();
        }

        private void Admin_Categories_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void Admin_Categories_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetCategoryInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("categoryid", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combobox_category_id.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void combobox_category_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;

            c.CommandText = "select * from categories";
            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                if (combobox_category_id.Text == dr[0].ToString())
                {
                    textBox_category_name.Text = dr[1].ToString();
                }
            }
            dr.Close();
        }

        private void btn_category_add_Click(object sender, EventArgs e)
        {
            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;

            c1.CommandText = "insert_category";
            c1.CommandType = CommandType.StoredProcedure;
            c1.Parameters.Add("categoryid", combobox_category_id.Text);
            c1.Parameters.Add("categoryname", textBox_category_name.Text);

            combobox_category_id.Items.Add(combobox_category_id.Text);
            c1.ExecuteNonQuery();

            MessageBox.Show("Category is Added Successfuly!");
        }

        private void btn_category_delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete CATEGORIES  where CATEGORY_ID=:CATEGORY_ID";
            cmd.Parameters.Add("CATEGORY_ID", combobox_category_id.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Category is Deleted Successfuly!");
            }
        }

        private void btn_category_update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update CATEGORIES set CATEGORY_NAME=:CATEGORY_NAME where CATEGORY_ID=:CATEGORY_ID";
            cmd.Parameters.Add("CATEGORY_NAME", textBox_category_name.Text);
            cmd.Parameters.Add("CATEGORY_ID", combobox_category_id.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Category is Updated Successfuly!");
            }
        }
    }
}
