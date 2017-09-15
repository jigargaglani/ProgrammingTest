using ProgrammingTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProgrammingTest.Persistence
{
    public class StudentContext: DbContext
    {
        public StudentContext(): base("name=StudentContext")
        {

        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}