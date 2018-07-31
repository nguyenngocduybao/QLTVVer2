using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class PhieuTraDAO
    {
        #region Instance
        private static PhieuTraDAO instance;

        public static PhieuTraDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuTraDAO(); return DAO.PhieuTraDAO.instance;
            }

            private set
            {
                DAO.PhieuTraDAO.instance = value;
            }
        }
        #endregion
        #region Count
        // Count ID
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.PHIEUTRAs select a.IDPhieuTra).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        //Tinh So ngay muon 
        public int SoNgayMuon(DateTime ngaytra ,int IDCTPhieuTra)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ngaymuon = (from a in db.CT_PHIEUTRA
                                from b in db.PHIEUMUONs
                                where a.IDPhieuMuon.Equals(b.IDPhieuMuon) && a.IDCTPhieuTra.Equals(IDCTPhieuTra)
                                select b.NgayMuon).ToString();
                DateTime NgayMuonSach = DateTime.Parse(ngaymuon);
                return (ngaytra - NgayMuonSach).Days;
            }
        }
        //Tinh tien phat
        public int TinhTienPhat(DateTime ngaytra, int IDCTPhieuTra)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var HanTra = (from a in db.CT_PHIEUTRA
                                from b in db.PHIEUMUONs
                                where a.IDPhieuMuon.Equals(b.IDPhieuMuon) && a.IDCTPhieuTra.Equals(IDCTPhieuTra)
                                select b.HanTra).ToString();
                DateTime HanTraSach = DateTime.Parse(HanTra);
                if ((ngaytra - HanTraSach).Days <= 0)
                    return 0;
                else
                    return (ngaytra - HanTraSach).Days * 1000;
            }
        }
        #endregion
        public List<int> ListIDCuonSach(int tb_IDPhieuMuon)
        {

            using (var db = new QuanLyThuVienEntities())
            {
                var list = (from a in db.PHIEUMUONs
                            join b in db.CT_PHIEUMUON on a.IDPhieuMuon equals b.IDPhieuMuon
                            join c in db.CUONSACHes on b.IDCuonSach equals c.IDCuonSach
                            where a.IDPhieuMuon.Equals(tb_IDPhieuMuon) && c.TinhTrang == "Đã cho mượn"
                            select b.IDCuonSach).ToList<int>();
                return list;
            }
        }
    }
}
