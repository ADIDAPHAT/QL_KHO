using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Kho.Gui
{
    public partial class UC_NCC : UserControl
    {
        public UC_NCC()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgvNCC.DataSource = BUS.BUS.xuat_ncc();
        }
        private void NCC_Load(object sender, EventArgs e)
        {
            xuat();
        }
        private void dgvnhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txt_tenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            txt_email.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
            txt_diaChi.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            txt_SDT.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
