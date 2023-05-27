using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbMainAd
    {
        [Key]
        public int mainAdID { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string MainAdText { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string MainAdImageBig { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Length must be less than 200")]
        public string MainAdImageSmall { get; set; }

        [Required]
        public int MainAdCurrentState { get; set; }

        [Required]
        public int MainAdCurrentlyFeatured { get; set; }
    }
}
