//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cafe_Otomasyonu.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urunler_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler_TBL()
        {
            this.Siparisler_TBL = new HashSet<Siparisler_TBL>();
        }
    
        public int Urun_ID { get; set; }
        public string Urun_Resim { get; set; }
        public string Urun_Adi { get; set; }
        public string Urun_Ayrinti { get; set; }
        public Nullable<short> Urun_Kategori { get; set; }
        public Nullable<decimal> Urun_Ucret { get; set; }
        public Nullable<int> Urun_Stok { get; set; }
    
        public virtual Kategoriler_TBL Kategoriler_TBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler_TBL> Siparisler_TBL { get; set; }
    }
}
