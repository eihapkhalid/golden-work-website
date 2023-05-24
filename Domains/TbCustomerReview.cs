using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbCustomerReview
    {
        public TbCustomerReview()
        {
            TbCustomer _TbCustomer = new TbCustomer();
        }
        [Key]
        public int CustomerReviewID { get; set; }
        [ValidateNever]
        

        [Required(ErrorMessage = "Customer Review Text is Required")]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string CustomerReviewText { get; set;}

        [Required]
        public int CustomerReviewRating { get; set;}

        [Required]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string CustomerReviewLogo { get; set;}

        [Required(ErrorMessage = "Update Time date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTime { get; set; }

        [Required(ErrorMessage = "Create Time date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserCreateTime { get; set; }

        [Required]
        public int CustomerReviewCurrentlyFeatured { get; set;}

        [Required]
        public int CustomerReviewCurrentState { get; set; }

        public int CustomerID { get; set; }
        public virtual TbCustomer _TbCustomer { get; set; }
    }
}
