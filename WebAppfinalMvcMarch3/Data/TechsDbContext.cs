using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using WebAppfinalMvcMarch3.Models;
using System.Data;

namespace WebAppfinalMvcMarch3.Data
{
    public class TechsDbContext : DbContext
    {
        public DbSet<PanelMember> PanelMembers { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<InterviewSchedule> InterviewSchedules { get; set; }

        
    }
}