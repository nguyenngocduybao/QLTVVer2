﻿using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface ICTPhieuMuonBUS
    {
        //add form CT_PhieuMuon
        bool addFormCTPhieuMuon(CTPhieuMuonDTO ctPhieuMuon);
    }
}
