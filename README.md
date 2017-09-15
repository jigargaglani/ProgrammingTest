# ProgrammingTest

Design Pattern - reposotory & unit of work pattern.
ORM - Entity Framework Code first
Angular Js 1.6 version
Web API Asp.Net 4.6

I opted for repository pattern because it is very helpful in keeping the application decoupled and even if we want to migrate from current ORM it is easier.

Created a generic Repository class that implements generic IRepository interface.
Created a UnitOfWork specific to this application with DBContext that connects to underlying database using EF code first approach.
Web API controller (StudentController) consists of basic Http rest methods to get list of students and create new student
The front end is binded with the server using Angular JS 1.6
