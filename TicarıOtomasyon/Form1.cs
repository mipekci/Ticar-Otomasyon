using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicarıOtomasyon
{
    public partial class TicariOtomasyon : DevExpress.XtraEditors.XtraForm
    {
        public TicariOtomasyon()
        {
            InitializeComponent();
        }

        private void barButtonIem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        frmürünler fr;
        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            if (fr == null)
            { 
                fr = new frmürünler();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barWorkspaceMenuItem1_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }
    }
}
