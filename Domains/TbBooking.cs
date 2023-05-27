using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbBooking
    {
        public TbBooking()
        {
            TbCustomer _TbCustomer = new TbCustomer();
            TbService _TbService = new TbService();
        }
        [Key]
        public int BookingID { get; set; }

        [Required(ErrorMessage = "Service Name  is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string BookingServiceName { get; set; }

        [Required(ErrorMessage = "First Name  is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string BookingFirstName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string BookingEmail { get; set; }

        [Required(ErrorMessage = "Booking date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Booking Start date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingStartDate { get; set; }

        [Required(ErrorMessage = "Booking End date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingEndDate { get; set; }

        [Required(ErrorMessage = "update date Time is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTime { get; set; }

        [Required(ErrorMessage = "User Update Timee is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTimee { get; set; }

        [Required]
        public int BookingCurrentState { get; set; }

        // Each booking belongs to only one customer  :
        public int CustomerID { get; set; }
        public virtual TbCustomer _TbCustomer { get; set; }
        // Each booking belongs to only one Service  :
        public int ServiceID { get; set; }
        public virtual TbService _TbService { get; set; }
    }
}


