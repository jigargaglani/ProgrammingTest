using ProgrammingTest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProgrammingTest.Core.Repositories;
using System.Data.Entity;
using ProgrammingTest.Persistence.Repositories;

namespace ProgrammingTest.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IStudentRepository StudentsRepository { get; private set; }

        private readonly StudentContext _context;

        public UnitOfWork(StudentContext context)
        {
            _context = context;
            StudentsRepository = new StudentRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}