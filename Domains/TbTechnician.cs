using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbTechnician
    {
        public int TechnicianID { get; set; }
        public string TechnicianName { get; set;}
        public string TechnicianExperience { get;set; }
        public string TechnicianQualification { get; set; }
        public string TechnicianImage { get; set; }
        public int TechnicianExpert { get; set; }
        public decimal TechnicianSalary { get; set; }
        public bool IsGetTechnicianSalary { get; set; }
        public DateTime UserUpdateTime { get; set; }
        public DateTime UserCreateTime { get; set; }
        public int TechnicianCurrentlyFeatured { get; set; }
        public int TechnicianCurrentState { get; set; }
    }
}
