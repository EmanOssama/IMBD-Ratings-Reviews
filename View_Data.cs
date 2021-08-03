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
    public partial class View_Data : Form
    {
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string constr = "Data Source=ORCL; User Id=scott; Password=scott;";
        string cmdstr = "";
        public View_Data()
        {
            InitializeComponent();
        }

        private void View_Data_Load(object sender, EventArgs e)
        {
  
        }

        private void View_Data_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton_view_movies_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_view_movies.Checked)
                cmdstr = "select * from movies";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton_view_user_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_view_user.Checked)
                cmdstr = "select * from users";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Row is Deleted Successfuly!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Row is Added Successfuly!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Row is Updated Successfuly!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButton_back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.ShowDialog();
        }

        private void radioButton_view_category_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_view_category.Checked)
                cmdstr = "select * from CATEGORIES";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton_view_prize_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_view_prize.Checked)
                cmdstr = "select * from prize";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
