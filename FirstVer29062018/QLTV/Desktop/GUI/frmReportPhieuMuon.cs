using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.GUI
{
    public partial class frmReportPhieuMuon : Form
    {
        public frmReportPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmReportPhieuMuon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
