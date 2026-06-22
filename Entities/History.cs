using System;
using System.Collections.Generic;

namespace Entities
{
    public class History
    {
        public int RecordID { get; set; }
        public DateTime NgayKham { get; set; }
        public string TenBenhNhan { get; set; }
        public string SDT { get; set; }
        public string BacSiKham { get; set; }
        public string ChanDoan { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
    }
}
