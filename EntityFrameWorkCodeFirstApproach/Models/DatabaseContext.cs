using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeFirstApproach.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("con_string") 
        { 

        }

        public DbSet<TblRegistration> TblRegistrations { get; set; }
    }
}