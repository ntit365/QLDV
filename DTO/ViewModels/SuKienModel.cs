﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ViewModels
{
    public class SuKienModel
    {
        public int ma_sk { get; set; }
        public string tieu_de { get; set; }
        public string noi_dung { get; set; }
        public string dia_diem { get; set; }
        public DateTime thoi_gian { get; set; }
        public DateTime thoi_gian_tao { get; set; }
        public string full_name { get; set; }
    }
}
