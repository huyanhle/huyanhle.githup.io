using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy.BUS;
using QuanLy.DTO;

namespace QuanLy
{
    public partial class fGiaHanHV : Form
    {
        private DataGridViewRow curRow;
        private HoiVienCTL hoiVienCTL;
        private HoiVienDTO hv;

        public fGiaHanHV()
        {
            InitializeComponent();
            cmbGoiTap.SelectedIndex = 0;
        }

        public fGiaHanHV(DataGridViewRow curRow)
        {
            InitializeComponent();
            this.curRow = curRow;
            cmbGoiTap.SelectedIndex = 0;
            hoiVienCTL = new HoiVienCTL();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                hv = new HoiVienDTO();
                hv.GoiTap = cmbGoiTap.Text;
                hv.ID_HV = curRow.Cells["id_hv"].Value.ToString();
                hv.NgayHetHan = (DateTime)curRow.Cells["ngayhethan"].Value;
                hv.GioiTinh = curRow.Cells["gioitinh"].Value.ToString();
                hv.HoTen = curRow.Cells["hoten"].Value.ToString();
                hv.SDT = curRow.Cells["sdt"].Value.ToString();
                hoiVienCTL.HoiVien = hv;
                hoiVienCTL.update();

                MessageBox.Show("Gia hạn THÀNH CÔNG!", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Gia hạn THẤT BẠI!", "Thông báo");
            }
        }
    }
}
