using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppfinalMvcMarch3.Models
{
    public class PanelMember
    {
        [Key]
        public int PanelMemberId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}