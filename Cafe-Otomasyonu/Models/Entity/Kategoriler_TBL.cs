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
    
    public partial class Kategoriler_TBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategoriler_TBL()
        {
            this.Urunler_TBL = new HashSet<Urunler_TBL>();
        }
    
        public short Kategori_ID { get; set; }
        public string Kategori_Ad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urunler_TBL> Urunler_TBL { get; set; }
    }
}
