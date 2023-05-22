using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbTechnician
    {
        [ValidateNever]
        [Key]
        public int TechnicianID { get; set; }

        [Required(ErrorMessage = "Technician  is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string TechnicianName { get; set;}

        [Required(ErrorMessage = "Technician Experience  is Required")]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string TechnicianExperience { get;set; }

        [Required(ErrorMessage = "Technician Qualification  is Required")]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string TechnicianQualification { get; set; }

        [Required]
        public string TechnicianImage { get; set; }

        [Required(ErrorMessage = "Technician Qualification  is Required")]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public int TechnicianExpert { get; set; }

        [Required]
        [Range(0.000000000001, 9999999999.99, ErrorMessage = "Technician Salary must be between 0.000000000001 and 9999999999.99.")]
        public decimal TechnicianSalary { get; set; }

        [Required]
        public bool IsGetTechnicianSalary { get; set; }

        [Required(ErrorMessage = "Payment date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTime { get; set; }

        [Required(ErrorMessage = "Payment date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserCreateTime { get; set; }
        [Required]
        public int TechnicianCurrentlyFeatured { get; set; }

        [ValidateNever]
        public int TechnicianCurrentState { get; set; }

        //TbTechnician has only user (Update Or Create):
        public TbUser UpdatedByUser { get; set; }
        public TbUser CreatedByUser { get; set; }
    }
}
