using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class ThongtinMe
    {
        public int ThongTinMeID { get; set; }

        public string ThongTinMeCode { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Begom { get; set; }
        public string CycloTron { get; set; }
        public string Belang { get; set; }
        public string BomHoaChat { get; set; }
        public string BeDieuHoa { get; set; }
        public string BeSBR1 { get; set; }
        public string BeSBR2 { get; set; }
        public string MayEpBun { get; set; }
    }
}