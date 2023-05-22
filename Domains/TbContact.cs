using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbContact
    {
        [Key]
        public int ContactID { get; set; }

        [Required(ErrorMessage = "Contact Name  is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string ContactName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        [RegularExpression("^[0-9]{10}$")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Phone must be between 9 and 50 characters.")]
        public int ContactPhone { get; set; }

        [Required(ErrorMessage = "ContactMessage is Required")]
        [StringLength(50, ErrorMessage = "Length must be less than 50")]
        public string ContactMessage { get; set; }

        [Required(ErrorMessage = "Payment date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserUpdateTime { get; set; }

        [Required(ErrorMessage = "Payment date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UserCreateTime { get; set; }

        [Required]
        public int ContactCurrentState { get; set; }

        //TbContact has only user (Update Or Create):
        public TbUser UpdatedByUser { get; set; }
        public TbUser CreatedByUser { get; set; }
    }
}
