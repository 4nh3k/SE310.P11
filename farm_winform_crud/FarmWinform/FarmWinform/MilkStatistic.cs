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
    
    public partial class MilkStatistic
    {
        public int StatisticsId { get; set; }
        public Nullable<int> AnimalId { get; set; }
        public System.DateTime Date { get; set; }
        public double MilkProduced { get; set; }
    
        public virtual Animal Animal { get; set; }
    }
}
