using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Desktop.GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form KiemTra(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void btn_TDG_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(FrmTheDocGia));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmTheDocGia f = new FrmTheDocGia();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }
    }
}