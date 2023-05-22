using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbAbout
    {
        [Key]
        public int AboutID { get; set; }

        [Required(ErrorMessage = "Company Name  is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string AboutCompanyName { get; set; }

        [Required(ErrorMessage = "Company Title  is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 100")]
        public string AboutCompanyTitle { get; set; }

        [Required(ErrorMessage = "Feature is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 100")]
        public string AboutFeature { get; set; }

        [Required(ErrorMessage = "Company Description is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 100")]
        public string AboutCompanyDescription { get; set;}

        [Required(ErrorMessage = "Company Address is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 100")]
        public string AboutCompanyAddress { get; set;}

        [Required(ErrorMessage = "Phone is required.")]
        [RegularExpression("^[0-9]{10}$")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Phone must be between 9 and 50 characters.")]
        public int AboutCompanyPhone { get;set;}

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string AboutCompanyEmail { get;set;}

        [Required(ErrorMessage = "Company Logo Satisfied is Required")]
        [StringLength(100, ErrorMessage = "Length must be less than 100")]
        public string AboutCompanyLogo { get;set;}

        [Required(ErrorMessage = "Company History Satisfied is Required")]
        [StringLength(100, ErrorMessage = "Length must be less than 100")]
        public string AboutCompanyHistory { get; set; }

        [Required(ErrorMessage = "Company Values Satisfied is Required")]
        [StringLength(100, ErrorMessage = "Length must be less than 100")]
        public string AboutCompanyValues { get; set; }

        [Required(ErrorMessage = "Company Achievements Satisfied is Required")]
        [StringLength(100, ErrorMessage = "Length must be less than 100")]
        public string AboutCompanyAchievements { get; set; }

        [Required]
        [Range(0.000000000001, 9999999999.99, ErrorMessage = "Technician Salary must be between 0.000000000001 and 9999999999.99.")]
        public int AboutCompletedProjects { get; set; }

        [Required]
        [Range(0.000001, 999999.99, ErrorMessage = "Technician Salary must be between 0.000001 and 999999.99.")]
        public int AboutYearsExperience { get;set; }
        public string AboutWorkingTime { get; set; }
        public string AboutWorkingDays { get; set; }

        [Required(ErrorMessage = "Update Time date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTime { get; set; }

        [Required(ErrorMessage = "Create Time date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserCreateTime { get; set; }
        [Required]
        public int AboutCurrentState { get; set; }

        //TbAbout has only user (Update Or Create):
        public TbUser UpdatedByUser { get; set; }
        public TbUser CreatedByUser { get; set; }
        
    }
}
