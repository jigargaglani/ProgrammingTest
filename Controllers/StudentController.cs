using ProgrammingTest.Core;
using ProgrammingTest.Models;
using ProgrammingTest.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProgrammingTest.Controllers
{
    public class StudentController : ApiController
    {
        private List<Student> students;
        private IUnitOfWork _uow = new UnitOfWork(new StudentContext());
        
        //dependency injection using unity
        public StudentController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public StudentController()
        {
        }

        // GET api/Student
        public IEnumerable<Student> Get()
        {
            students = new List<Student>();
            
            students = _uow.StudentsRepository.GetAll().ToList();
            
            return students;
        }

        // GET api/Student/5
        public Student Get(int id)
        {
            var student = new Student();
            student = _uow.StudentsRepository.Get(id);

            return student;
        }

        // POST api/Student
        public HttpResponseMessage Post(Student student)
        {
            _uow.StudentsRepository.Add(student);
            _uow.SaveChanges();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, Get().ToList());
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = student.Id }));
            return response;
        }

        // PUT api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Student/5
        public void Delete(int id)
        {
        }
    }
}
