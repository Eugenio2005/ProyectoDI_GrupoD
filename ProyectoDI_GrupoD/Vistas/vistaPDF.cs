using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ProyectoDI_GrupoD.Vistas
{
    public partial class vistaPDF : Form
    {
        public vistaPDF()
        {
            InitializeComponent();
        }

        private void vistaPDF_Load(object sender, EventArgs e)
        {
            CrystalReport1 report1 = new CrystalReport1();
            crystalReportViewer1.ReportSource = report1;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 report1 = new CrystalReport1();
            crystalReportViewer1.ReportSource = report1;
            
        }

    }
}
