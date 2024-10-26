//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiningPlantConsole.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MilitaryContracts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MilitaryContracts()
        {
            this.EquipmentMaterials = new HashSet<EquipmentMaterials>();
            this.Taxes = new HashSet<Taxes>();
        }
    
        public int ContractID { get; set; }
        public System.DateTime ContractDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public decimal Quantity { get; set; }
        public int MineralID { get; set; }
        public int StatusID { get; set; }
        public int EmployeeID { get; set; }
    
        public virtual Employees Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentMaterials> EquipmentMaterials { get; set; }
        public virtual Minerals Minerals { get; set; }
        public virtual OrderStatuses OrderStatuses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taxes> Taxes { get; set; }
    }
}
