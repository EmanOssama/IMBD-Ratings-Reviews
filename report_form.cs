using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace IMBD1
{
    public partial class report_form : Form
    {
        CrystalReport1 cr;
        public report_form()
        {
            InitializeComponent();
            cr = new CrystalReport1();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void report_form_Load(object sender, EventArgs e)
        {
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void report_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
