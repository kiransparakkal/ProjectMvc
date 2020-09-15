using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ProjectWebsite.Models
{
	public class feedback
	{
        [Required]
        [Display(Name = "User ID")]
        public int FeedbackId { get; set; }
        [Required]
        [Display(Name = "User ID")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Feedback")]
        public string Feedback1 { get; set; }
        [Required]
        [Display(Name = "Feedback Date")]
        public Nullable<System.DateTime> FeedbackDate { get; set; }

        public virtual User tbluser { get; set; }
    }
}