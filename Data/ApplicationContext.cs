using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCPerson.Models;
using NguyenTheAnh0264.Models;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MVCPerson.Models.PersonNTA264> PersonNTA264 { get; set; }

        public DbSet<NguyenTheAnh0264.Models.NTA0264> NTA0264 { get; set; }
    }
