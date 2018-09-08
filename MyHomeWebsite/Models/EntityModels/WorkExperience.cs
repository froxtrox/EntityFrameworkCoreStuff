using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeWebsite.Models
{
    public class WorkExperience
    {
        public WorkExperience()
        {

        }
        public string experience { get; set; }
        public string Responsibility { get; set; }
        public string SkillGained { get; set; }
        public TimePeriod timePeriod { get; set; }
        public Guid ID { get; set; }
    }
}
