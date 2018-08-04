﻿using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface ISachBUS
    {
        // Add Form Sach
        bool ADDFormSach(SachDTO sach);
        //EditForm DauSach, Sach, CT_PhieuNhap
        bool editFormDauSachAndSachAndCTPhieuNhap(SachDTO sach);
        #region getListSearch SachDTO
        //get List Search IDSach 
        List<SachDTO> getFormSachSearchIDSach(int IDsach);
        //get List Search TenDauSach
        List<SachDTO> getFormSachTenDauSach(string TenDauSach);
        // get List Search NhaXuatBan
        List<SachDTO> getFormSachNhaXuatBan(string NhaxB);
        // get List Search NamXuatBan 
        List<SachDTO> getFormSachNamXuatBan(string NamXB);
        // get List Search GiaTien
        List<SachDTO> getFormSachSearchGiaTien(decimal tien);
        //get List Search SoLuongTon
        List<SachDTO> getFormSachSearchSoLuongTon(int SL);
        #endregion
    }
}
