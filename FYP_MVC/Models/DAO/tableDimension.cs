//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FYP_MVC.Models.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tableDimension
    {
        public int ID { get; set; }
        public Nullable<int> tableID { get; set; }
        public Nullable<int> dimensionIndex { get; set; }
        public Nullable<int> cardinality { get; set; }
        public string context { get; set; }
        public Nullable<int> isContinuous { get; set; }
    
        public virtual table table { get; set; }
    }
}
