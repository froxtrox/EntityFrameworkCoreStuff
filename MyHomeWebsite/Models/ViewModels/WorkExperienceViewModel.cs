using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeWebsite.Models
{
    public class WorkExperienceViewModel
    {
        public WorkExperience CurrentWorkExperience { get; set; }
        public IEnumerable<TimePeriod> timePeriods { get; set; }
    }
}

    