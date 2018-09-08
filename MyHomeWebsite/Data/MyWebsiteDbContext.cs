using Microsoft.EntityFrameworkCore;
using MyHomeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeWebsite.Data
{
    public class MyWebsiteDbContext : DbContext
    {
        public MyWebsiteDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<WorkExperience> workExperiences { get; set; }      
    }
}
