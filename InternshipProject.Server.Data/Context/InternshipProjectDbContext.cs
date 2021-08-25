using InternshipProject.Server.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipProject.Server.Data.Context
{
    public class InternshipProjectDbContext:DbContext
    {
        public InternshipProjectDbContext(DbContextOptions<InternshipProjectDbContext> options):base(options)
        {

        }
        public virtual DbSet<User>   Users { get; set; }
        public virtual DbSet<Flats> Flats { get; set; }
        public virtual DbSet<Debt> Debts { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<Announcements> Announcements { get; set; }

        
    }
}
