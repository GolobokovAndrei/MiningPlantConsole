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
    
    public partial class MineralTracking
    {
        public int TrackingID { get; set; }
        public int MineralID { get; set; }
        public int OperationTypeID { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime OperationDate { get; set; }
        public int DestinationID { get; set; }
    
        public virtual Destinations Destinations { get; set; }
        public virtual Minerals Minerals { get; set; }
        public virtual OperationTypes OperationTypes { get; set; }
    }
}
