using ProgrammingTest.Core.Repositories;
using ProgrammingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammingTest.Persistence.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentContext StudentContext { get { return Context as StudentContext; } }

        public StudentRepository(StudentContext studentContext): base(studentContext)
        {
        }
    }
}