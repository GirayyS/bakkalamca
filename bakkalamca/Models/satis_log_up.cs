//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bakkalamca.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class satis_log_up
    {
        public int slu_id { get; set; }
        public Nullable<System.DateTime> eski_s_tarih { get; set; }
        public Nullable<System.DateTime> yeni_s_tarih { get; set; }
        public string eski_s_durum { get; set; }
        public string yeni_s_durum { get; set; }
        public Nullable<int> eski_kullanici_id { get; set; }
        public Nullable<int> yeni_kullanici_id { get; set; }
        public System.DateTime islem_tarihi { get; set; }
        public string islem_ip { get; set; }
    }
}