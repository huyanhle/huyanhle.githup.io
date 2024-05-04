using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class SanPhamDTO
    {
        private string _id;
        private string _ten;
        private string _loai;
        private DateTime _ngaynhap;
        private int _soluong;
        private string _dongia;
        private string _trongluong;
        private string _hangsx;
        private string _tinhtrang;
        private Byte[] _hinhanh;

        public string ID_SP
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }

        public DateTime NgayNhap
        {
            get { return _ngaynhap; }
            set { _ngaynhap = value; }
        }

        public int SoLuong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        public string DonGia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }

        public string TrongLuong
        {
            get { return _trongluong; }
            set { _trongluong = value; }
        }

        public string HangSX
        {
            get { return _hangsx; }
            set { _hangsx = value; }
        }

        public string TinhTrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }

        public Byte[] HinhAnh
        {
            get { return _hinhanh; }
            set { _hinhanh = value; }
        }
    }
}
