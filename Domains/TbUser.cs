using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Domains
{
    public class TbUser
    {
        [Key]
        [ValidateNever]
        public int UserID { get; set; }

        [Required(ErrorMessage = "User Name is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string UserName { get; set; }

        [Required (ErrorMessage = "Password is Required")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 20 characters.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[\\W_])[A-Za-z\\d\\W_]{8,20}$")]
        public string UserPassword { get; set; }

        [Required (ErrorMessage ="Email is Required")]
        [StringLength(50, ErrorMessage ="Length must be less than 50")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "User Role is Required")]
        [StringLength(50, ErrorMessage ="length must be less than 50")]
        public string UserRole { get; set; }

        [Required(ErrorMessage = "Update Time date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTime { get; set; }

        [Required(ErrorMessage = "Create Time date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserCreateTime { get; set; }

        [ValidateNever]
        public int UserCurrentState { get; set; }
    }
}
