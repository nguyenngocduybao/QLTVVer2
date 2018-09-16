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
    public partial class frmReportPhieuTra : Form
    {
        public frmReportPhieuTra()
        {
            InitializeComponent();
        }

        private void frmReportPhieuTra_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
