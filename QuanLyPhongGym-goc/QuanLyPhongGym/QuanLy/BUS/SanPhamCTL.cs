using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy.DAO;
using QuanLy.DTO;

namespace QuanLy.BUS
{
    public class SanPhamCTL
    {
        private SanPhamDAO data = new SanPhamDAO();
        private SanPhamDTO info = new SanPhamDTO();

        public SanPhamDTO SanPham
        {
            get { return info; }
            set { info = value; }
        }

        public void insert()
        {
            data.insert(info);
        }

        public void delete()
        {
            data.delete(info.ID_SP);
        }

        public void update()
        {
            data.update(info);
        }

        public void exit()
        {
            data.exit();
        }

        public ArrayList getDsSanPham()
        {
            return data.getDsSanPham();
        }

        public ArrayList getDsSanPham(string keyword)
        {
            return data.getDsSanPham(keyword);
        }
    }
}
