using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbCustomer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "First Name  is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string CustomerFirstName { get; set; }

        [Required(ErrorMessage = "Last Name  is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string CustomerLastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string CustomerEmail { get; set;}

        [Required(ErrorMessage = "Phone is required.")]
        [RegularExpression("^[0-9]{10}$")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Phone must be between 9 and 50 characters.")]
        public int CustomerPhone { get; set;}

        [Required(ErrorMessage = "Address is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string CustomerAddress { get; set;}

        [Required(ErrorMessage = "Customer Satisfied is Required")]
        [StringLength(100, ErrorMessage = "Length must be less than 100")]
        public string CustomerSatisfied { get; set;}

        [Required(ErrorMessage = "Update Time date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTime { get; set; }

        [Required(ErrorMessage = "Create Time date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserCreateTime { get; set; }

        [Required]
        public int CustomerCurrentState { get; set; }

        //TbCustomer has only user (Update Or Create):
        public TbUser UpdatedByUser { get; set; }
        public TbUser CreatedByUser { get; set; }
    }
}
