//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string UserId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ProductName { get; set; }
        public string Feedback1 { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<System.DateTime> FeedbackDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}