//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hardware
{
    using System;
    using System.Collections.Generic;
    
    public partial class CPUs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPUs()
        {
            this.Configurations = new HashSet<Configurations>();
        }
    
        public string Name { get; set; }
        public string Socket { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        public string power { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configurations> Configurations { get; set; }
    }
}
