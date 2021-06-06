using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EductionFinalProject.Models;

namespace EductionFinalProject.Data
{
    public class EductionFinalProjectContext : DbContext
    {
        public EductionFinalProjectContext (DbContextOptions<EductionFinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<EductionFinalProject.Models.CourseRecord> CourseRecord { get; set; }

        public DbSet<EductionFinalProject.Models.Query> Query { get; set; }

        public DbSet<EductionFinalProject.Models.Staff> Staff { get; set; }

        public DbSet<EductionFinalProject.Models.Student> Student { get; set; }

        public DbSet<EductionFinalProject.Models.Register> Register { get; set; }
    }
}
