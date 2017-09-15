# ProgrammingTest using visual studio 2017

* Design Pattern - reposotory & unit of work pattern.
* ORM - Entity Framework Code first
* Angular Js 1.6 version (have no prior experience with Angular so did some research and learning before applying it)
* Web API Asp.Net 4.6
* Unit test project using Moq

I opted for repository pattern because it is very helpful in keeping the application decoupled and even if we want to migrate from current ORM it is easier.

Created a generic Repository class that implements generic IRepository interface.
Created a UnitOfWork specific to this application with DBContext that connects to underlying database using EF code first approach.
Web API controller (StudentController) consists of basic Http rest methods to get list of students and create new student
The front end is binded with the server using Angular JS 1.6

#### P.S. - The repository didn't fetch unit test project. Will attach it in the email ####
