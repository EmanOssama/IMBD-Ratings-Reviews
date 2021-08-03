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
using CrystalDecisions.Shared;

namespace IMBD1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_manage_movies_Click(object sender, EventArgs e)
        {
            Admin_Movies ad_m = new Admin_Movies();
            this.Hide();
            ad_m.ShowDialog();
        }

        private void btn_manage_actors_Click(object sender, EventArgs e)
        {
            Admin_Person ad_a = new Admin_Person();
            this.Hide();
            ad_a.ShowDialog();
        }

        private void btn_view_data_Click(object sender, EventArgs e)
        {
            View_Data vd = new View_Data();
            this.Hide();
            vd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Categories ac = new Admin_Categories();
            this.Hide();
            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Prize ap = new Admin_Prize();
            this.Hide();
            ap.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report_form rf = new report_form();
            this.Hide();
            rf.ShowDialog();
        }
    }
}
