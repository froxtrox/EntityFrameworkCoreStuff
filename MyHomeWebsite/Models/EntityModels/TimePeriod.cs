using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeWebsite.Models
{
    public class TimePeriod
    {
        public Guid ID { get; set; }
        public TimePeriod(DateTime startTime, DateTime endTime)
        {
            Start_Time = startTime;
            End_Time = endTime;
        }
        [Required]
        public DateTime Start_Time
        {
            get; set;
        }
        [Required]
        public DateTime End_Time
        {
            get; set;
        }
    }
}
