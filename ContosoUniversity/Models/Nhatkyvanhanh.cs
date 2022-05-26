using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContosoUniversity.Models
{
    public class Nhatkyvanhanh
    {
        public int NhatkyvanhanhID { get; set; }

        public string MotaNhatky { get; set; }

        public string Thongtinsuco { get; set; }
        
        public float Luuluongvao { get; set; }
        public float Luuluongra { get; set; }
        public float Chisotieuthudien { get; set; }
        public float Khoiluongtieuthudien { get; set; }
        public float polymervao { get; set; }
        public float polymerra { get; set; }
        public float phabotvao { get; set; }
        public float phabotra { get; set; }
        public string NguoiTruc { get; set; }

    }
}