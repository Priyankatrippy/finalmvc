using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppfinalMvcMarch3.Models
{
    public class InterviewSchedule
    {
        [Key]
        public int InterviewScheduleId { get; set; }

        [Required]
        public DateTime InterviewDateTime { get; set; }

        [Required]
        public string Location { get; set; }

        public string Notes { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }
}