//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Strahovoe
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usluga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usluga()
        {
            this.Ychet_Polisov = new HashSet<Ychet_Polisov>();
        }
    
        public int Usluga_ID { get; set; }
        public string Usluga_Vid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ychet_Polisov> Ychet_Polisov { get; set; }
    }
}
