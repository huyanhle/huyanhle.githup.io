using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy.DAO;
using QuanLy.DTO;

namespace QuanLy.BUS
{
    public class HoiVienCTL
    {
        private HoiVienDAO data = new HoiVienDAO();
        private HoiVienDTO info = new HoiVienDTO();

        public HoiVienDTO HoiVien
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
            data.delete(info.ID_HV);
        }

        public void update()
        {
            data.update(info);
        }

        public void exit()
        {
            data.exit();
        }

        public ArrayList getDsHocVien()
        {
            return data.getDsHocVien();
        }

        public ArrayList getDsHocVien(string keyword)
        {
            return data.getDsHocVien(keyword);
        }
    }
}
