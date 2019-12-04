//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PropertyManagement1.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            this.Full_Contract = new HashSet<Full_Contract>();
            this.Installment_Contract = new HashSet<Installment_Contract>();
        }
    
        public int ID { get; set; }
        public string Property_Code { get; set; }
        public string Property_Name { get; set; }
        public int Property_Type_ID { get; set; }
        public string Description { get; set; }
        public int District_ID { get; set; }
        public string Address { get; set; }
        public Nullable<int> Area { get; set; }
        public Nullable<int> Bed_Room { get; set; }
        public Nullable<int> Bath_Room { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<double> Installment_Rate { get; set; }
        public string Avatar { get; set; }

        public string Album { get; set; }
        public int Property_Status_ID { get; set; }
    
        public virtual District District { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Full_Contract> Full_Contract { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Installment_Contract> Installment_Contract { get; set; }
        public virtual Property_Status Property_Status { get; set; }
        public virtual Property_Type Property_Type { get; set; }
    }
}
