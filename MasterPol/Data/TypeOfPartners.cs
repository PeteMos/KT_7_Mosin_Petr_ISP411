//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPol.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeOfPartners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeOfPartners()
        {
            this.PartnersImport = new HashSet<PartnersImport>();
        }
    
        public int Id { get; set; }
        public string TypeOfPartner { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnersImport> PartnersImport { get; set; }
    }
}
