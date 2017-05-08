using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Kho.BUS;
using QL_Kho.DT0;

namespace QL_Kho.Gui
{
    public partial class UC_NhapHang : UserControl
    {
        bool them1, sua1;
        public UC_NhapHang()
        {
            InitializeComponent();
        }
        DataTable a = new DataTable();
        private void load()
        {
            DataTable a = new DataTable();
            a = BUS.BUS.xuat_pn();
            dgvphieuNhap.DataSource = a;
        }
        
        private void dgvphieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma_PN.Text = dgvphieuNhap.CurrentRow.Cells[0].Value.ToString();
            txttongTien.Text = dgvphieuNhap.CurrentRow.Cells[2].Value.ToString();
            datePK.Text = dgvphieuNhap.CurrentRow.Cells[1].Value.ToString();
            txtma_PN.Enabled = false;
            datePK.Enabled = false;

            dgvCTN.DataSource = BUS.BUS.xuat_ctn(txtma_PN.Text);
        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            load();
            txttongTien.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtma_PN.Enabled = true;
            datePK.Enabled = true;
            txtma_PN.Clear();
            txttongTien.Clear();
            them1 = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            datePK.Enabled = true;
            sua1 = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            PhieuNhap a = new PhieuNhap();
            a.MaPN = txtma_PN.Text.Trim();

            if (BUS.BUS.xoa_PN(a) != 0)
            {
                MessageBox.Show("xoa thanh cong");
                dgvphieuNhap.DataSource = BUS.BUS.xuat_pn();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them1)
            {
                PhieuNhap a = new PhieuNhap();
                a.MaPN = txtma_PN.Text.Trim();
                a.NgayNhap = datePK.Value;
                a.TongTien = 0;
                if (BUS.BUS.them_pn(a) != 0)
                {
                    MessageBox.Show("Them thanh cong");
                    dgvphieuNhap.DataSource = BUS.BUS.xuat_pn();
                }
                them1 = false;
            }
            else if (sua1)
            {
                PhieuNhap a = new PhieuNhap();
                a.MaPN = txtma_PN.Text.Trim();
                a.NgayNhap = datePK.Value;
                a.TongTien = 0;
                if (BUS.BUS.sua_PN(a) != 0)
                {
                    MessageBox.Show("Sua thanh cong");
                    dgvphieuNhap.DataSource = BUS.BUS.xuat_pn();
                }
                sua1 = false;
            }
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
