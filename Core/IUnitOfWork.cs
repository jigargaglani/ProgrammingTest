using ProgrammingTest.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository StudentsRepository { get; }
        void SaveChanges();
    }
}
