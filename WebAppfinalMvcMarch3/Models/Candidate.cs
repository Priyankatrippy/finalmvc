using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppfinalMvcMarch3.Models
{
    public class Candidate
    {
        [Key]
        public int CandidateId { get; set; }

        [Required]
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}