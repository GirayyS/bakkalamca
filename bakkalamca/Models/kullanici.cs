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
    
    public partial class kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kullanici()
        {
            this.satis = new HashSet<satis>();
        }
    
        public int kullanici_id { get; set; }
        public string k_kullaniciadi { get; set; }
        public string k_parola { get; set; }
        public string k_adi { get; set; }
        public string k_soyadi { get; set; }
        public string k_eposta { get; set; }
        public string k_telefon { get; set; }
        public bool k_durum { get; set; }
        public int rol_id { get; set; }
    
        public virtual rol rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<satis> satis { get; set; }
    }
}