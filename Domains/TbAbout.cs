using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbAbout
    {
        public int AboutID { get; set; }
        public string AboutCompanyName { get; set; }
        public string AboutCompanyTitle { get; set; }
        public string AboutFeature { get; set; }
        public string AboutCompanyDescription { get; set;}
        public string AboutCompanyAddress { get; set;}
        public int AboutCompanyPhone { get;set;}
        public string AboutCompanyEmail { get;set;}
        public string AboutCompanyLogo { get;set;}
        public string AboutCompanyHistory { get; set; }
        public string AboutCompanyValues { get; set; }
        public string AboutCompanyAchievements { get; set; }
        public int AboutCompletedProjects { get; set; }
        public int AboutYearsExperience { get;set; }
        public string AboutWorkingTime { get; set; }
        public string AboutWorkingDays { get; set; }
        public DateTime UserUpdateTime { get; set; }
        public DateTime UserCreateTime { get; set; }
        public int AboutCurrentState { get; set; }

        //TbAbout has only user (Update Or Create):
        public TbUser UpdatedByUser { get; set; }
        public TbUser CreatedByUser { get; set; }
        
    }
}
