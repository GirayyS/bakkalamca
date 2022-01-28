using bakkalamca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bakkalamca.ViewModels
{
    public class FaturaClass
    {
        public FaturaClass()
        {
            katego = new kategori();
            sat = new satis();
            smadde = new satis_maddeleri();
            uru = new urun();
            mark = new marka();
            kullanic = new kullanici();
        }

        public kategori katego { get; set; }
        public satis sat { get; set; }
        public satis_maddeleri smadde { get; set; }
        public urun uru { get; set; }
        public marka mark { get; set; }
        public kullanici kullanic { get; set; }
    }
}