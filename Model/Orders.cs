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
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.EquipmentMaterials = new HashSet<EquipmentMaterials>();
            this.Taxes = new HashSet<Taxes>();
        }
    
        public int OrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string Country { get; set; }
        public decimal Quantity { get; set; }
        public int MineralID { get; set; }
        public bool IsExport { get; set; }
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
