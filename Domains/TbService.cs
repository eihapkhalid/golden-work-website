using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbService
    {
        public TbService()
        {
            ICollection<TbBooking> _TbBookings = new HashSet<TbBooking>();
        }
        [Key]
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Service Name  is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string ServiceName { get; set; }

        [Required(ErrorMessage = "Service Title  is Required")]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string ServiceTitle { get; set; }

        [Required(ErrorMessage = "Service Description  is Required")]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string ServiceDescription { get; set; }

        [Required]
        [Range(0.000000000001, 9999999999.99, ErrorMessage = "Technician Salary must be between 0.000000000001 and 9999999999.99.")]
        public decimal ServicePrice { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string ServiceImage { get; set;}

        [Required(ErrorMessage = "Update Time date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTime { get; set; }

        [Required(ErrorMessage = "Create Time date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserCreateTime { get; set; }

        [Required]
        public int ServiceCurrentlyFeatured { get; set;}

        [ValidateNever]
        public int ServiceCurrentState { get; set; }

        // A single Service can make multiple bookings :
        public virtual ICollection<TbBooking> _TbBookings { get; set; }


    }
}
