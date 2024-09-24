//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmWinform
{
    using System;
    using System.Collections.Generic;
    
    public partial class Animal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Animal()
        {
            this.MilkStatistics = new HashSet<MilkStatistic>();
        }
    
        public int AnimalId { get; set; }
        public Nullable<int> AnimalTypeId { get; set; }
        public double MilkProduced { get; set; }
        public int OffspringCount { get; set; }
    
        public virtual AnimalType AnimalType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MilkStatistic> MilkStatistics { get; set; }
    }
}
