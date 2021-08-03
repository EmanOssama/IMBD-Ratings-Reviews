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
    public partial class Form1 : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott;Password=scott;";
        OracleConnection conn;
        string userphoto = "";
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        public Form1(string photouser)
        {
            InitializeComponent();
            customizeDesign();
            userphoto = photouser;
        }
        private void customizeDesign()
        {
            panelSubMenuMovies.Visible = false;
            panelSubMenuTVShows.Visible = false;
            panelSubMenuAwards.Visible = false;
            panelSubMenuCelebrates.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenuMovies.Visible == true)
                panelSubMenuMovies.Visible = false;
            if (panelSubMenuTVShows.Visible == true)
                panelSubMenuTVShows.Visible = false;
            if (panelSubMenuAwards.Visible == true)
                panelSubMenuAwards.Visible = false;
            if (panelSubMenuCelebrates.Visible == true)
                panelSubMenuCelebrates.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btn_Movies_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMovies);
        }

        private void btn_TVShows_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuTVShows);
        }

        private void btn_Awards_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAwards);
        }

        private void btn_Celebrates_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCelebrates);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Enter Search Word";
            if (radioButton1.Checked)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select TITLE from movies";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0]);
                }
                dr.Close();
            }
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm l = new LoginForm();
            l.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            pictureBox2.ImageLocation = userphoto;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            Application.Exit();
        }

        private void btn_Movies_MouseHover(object sender, EventArgs e)
        {
            btn_Movies.ForeColor = Color.LemonChiffon;
            btn_Movies.IconColor = Color.LemonChiffon;
        }

        private void btn_Movies_MouseLeave(object sender, EventArgs e)
        {
            btn_Movies.ForeColor = Color.Gold;
            btn_Movies.IconColor = Color.Gold;
        }

        private void btn_Movies_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_Movies_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn_Movies_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LemonChiffon;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.LemonChiffon;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gold;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.LemonChiffon;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Gold;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.ForeColor = Color.LemonChiffon;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Gold;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.ForeColor = Color.LemonChiffon;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Gold;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.ForeColor = Color.LemonChiffon;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Gold;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.ForeColor = Color.LemonChiffon;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.ForeColor = Color.Gold;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.ForeColor = Color.LemonChiffon;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.ForeColor = Color.Gold;
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            button11.ForeColor = Color.LemonChiffon;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.ForeColor = Color.Gold;
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            button13.ForeColor = Color.LemonChiffon;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.ForeColor = Color.Gold;
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            button14.ForeColor = Color.LemonChiffon;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.ForeColor = Color.Gold;
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            button15.ForeColor = Color.LemonChiffon;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.ForeColor = Color.Gold;
        }

        private void btn_TVShows_MouseHover(object sender, EventArgs e)
        {
            btn_TVShows.ForeColor = Color.LemonChiffon;
            btn_TVShows.IconColor = Color.LemonChiffon;
        }

        private void btn_TVShows_MouseLeave(object sender, EventArgs e)
        {
            btn_TVShows.ForeColor = Color.Gold;;
            btn_TVShows.IconColor = Color.Gold;
        }

        private void btn_Awards_MouseHover(object sender, EventArgs e)
        {
            btn_Awards.ForeColor = Color.LemonChiffon;
            btn_Awards.IconColor = Color.LemonChiffon;
        }

        private void btn_Awards_MouseLeave(object sender, EventArgs e)
        {
            btn_Awards.ForeColor = Color.Gold;
            btn_Awards.IconColor = Color.Gold;
        }

        private void btn_Celebrates_MouseHover(object sender, EventArgs e)
        {
            btn_Celebrates.ForeColor = Color.LemonChiffon;
            btn_Celebrates.IconColor = Color.LemonChiffon;
        }

        private void btn_Celebrates_MouseLeave(object sender, EventArgs e)
        {
            btn_Celebrates.ForeColor = Color.Gold;
            btn_Celebrates.IconColor = Color.Gold;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Enter Search Word";
            if (radioButton2.Checked)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select TITLE from prize";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0]);
                }
                dr.Close();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Enter Search Word";
            if (radioButton3.Checked)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select USER_NAME from actor";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0]);
                }
                dr.Close();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
