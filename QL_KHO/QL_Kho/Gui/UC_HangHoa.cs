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
    public partial class UC_HangHoa : UserControl
    {
        public UC_HangHoa()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            xuat();
        }
        private void dgvhangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaHH.Text = dgvhangHoa.CurrentRow.Cells[0].Value.ToString();
            txttenHH.Text = dgvhangHoa.CurrentRow.Cells[1].Value.ToString();
            txtnhaCC.Text = dgvhangHoa.CurrentRow.Cells[2].Value.ToString();
            txtsoLuong.Text = dgvhangHoa.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
