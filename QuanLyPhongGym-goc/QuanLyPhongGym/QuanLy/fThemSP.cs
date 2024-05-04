using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy.BUS;
using QuanLy.DTO;

namespace QuanLy
{
    public partial class fThemSP : Form
    {
        private SanPhamCTL sanPhamCTL = new SanPhamCTL();
        private SanPhamDTO sp = new SanPhamDTO();
        private int iLastRowID;
        private string imgLoc;

        public fThemSP()
        {
            InitializeComponent();
        }

        public fThemSP(string lastRowID)
        {
            InitializeComponent();
            dateTimePicker.CustomFormat = "MM/dd/yyyy";
            cmbLoaiSP.SelectedIndex = 0;

            string sub = lastRowID.Substring(Math.Max(0, lastRowID.Length - 3));
            iLastRowID = Int32.Parse(sub);
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private Byte[] ImageToByteArray(string imgLocation)
        {
            Byte[] img = null;
            FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            return img;
        }

        private void LayThongTinSanPham()
        {
            sp.Ten = txtTenSP.Text;
            sp.Loai = cmbLoaiSP.Text;
            sp.DonGia = txtDonGiaSP.Text;
            sp.TrongLuong = txtTrongLuongSP.Text;
            sp.HangSX = txtHangSXSP.Text;
            sp.TinhTrang = "Còn hàng";
            sp.NgayNhap = dateTimePicker.Value;

            int result = 0;
            bool b = int.TryParse(txtSoLuongSP.Text, out result);
            sp.SoLuong = result;

            iLastRowID++;
            sp.ID_SP = "SP00" + iLastRowID.ToString();

            if (picBoxHV.Image != null)
                sp.HinhAnh = ImageToByteArray(imgLoc);
        }

        private void txtSoLuongSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnXoaHetSP_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            try
            {
                LayThongTinSanPham();
                sanPhamCTL.SanPham = sp;
                sanPhamCTL.insert();

                MessageBox.Show("Thêm THÀNH CÔNG!", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa thêm ảnh!", "Thông báo");
            }
        }

        private void picBoxHV_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Chọn ảnh đại diện";
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName;
                    picBoxHV.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
