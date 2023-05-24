using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbNews
    {
        [Key]
        public int NewsID { get; set; }

        [Required(ErrorMessage = "News Title  is Required")]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string NewsTitle { get; set; }

        [Required(ErrorMessage = "News Content is Required")]
        [StringLength(500, ErrorMessage = "Length must be less than 500")]
        public string NewsContent { get; set; }

        [Required(ErrorMessage = "Payment date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NewsDate { get; set; }

        [Required(ErrorMessage = "Update Time date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTime { get; set; }

        [Required(ErrorMessage = "Create Time date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserCreateTime { get; set; }
        [Required]
        public int NewsCurrentState { get; set; }

        [ValidateNever]
        public int NewsCurrentlyFeatured { get; set; }
    }
}
