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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Feedbacks = new HashSet<Feedback>();
            this.ProductCarts = new HashSet<ProductCart>();
        }
    
        public int ProductId { get; set; }
        public Nullable<int> SubCategoryId { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCart> ProductCarts { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
