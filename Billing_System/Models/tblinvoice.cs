//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Billing_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblinvoice
    {
        public int invoice_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<System.DateTime> invoice_date { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<double> rate { get; set; }
        public Nullable<double> tax { get; set; }
        public Nullable<int> stock_quantity { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<double> total { get; set; }
    
        public virtual tblproduct tblproduct { get; set; }
        public virtual tblcutomer tblcutomer { get; set; }
    }
}
