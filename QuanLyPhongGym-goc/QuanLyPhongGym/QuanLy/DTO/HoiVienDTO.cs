using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class HoiVienDTO
    {
        private string _id;
        private string _hoten;
        private string _gioitinh;
        private string _sdt;
        private DateTime _ngayhethan;
        private string _goitap;
        private Byte[] _hinhanh;

        public string ID_HV
        {
            get { return _id; }
            set { _id = value; }
        }

        public string HoTen
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        public string GioiTinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public DateTime NgayHetHan
        {
            get { return _ngayhethan; }
            set { _ngayhethan = value; }
        }

        public string GoiTap
        {
            get { return _goitap; }
            set { _goitap = value; }
        }

        public Byte[] HinhAnh
        {
            get { return _hinhanh; }
            set { _hinhanh = value; }
        }
    }
}
