# T-514-VEFT - Assignment 1
* Teacher: 
    - Daníel Brandur Sigurgeirsson
* Students:
    - Hólmfríður Guðlaug Einarsdóttir
    - Þorvarður Bergmann Kjartansson

Table of contents
=================
* [Assignment description](#assignment-description)
* [TODO List](#todo-list)
* [Install Guide](#install-guide)

Assignment description
======================
Your first assignment is to design and create a REST service using .NET Core and ASP.NET Web API. It should model courses and their students.
A course should have the following properties - all required
  - Name (Example: "Web services")
  - TemplateID (Example: "T-514-VEFT")
  - ID (Example: 1)
  - StartDate (Example: 2016-08-17)
  - EndDate (Example: 2016-11-08)

A student has the following properties - all required
  - SSN
  - Name

It should support the following operations:
  - Get a list of courses (10%)
  - Add a course (10%)
  - Update a course (10%)
  - Delete a course (10%)
  - Get a course with a given ID (10%)
  - Get a list of students in a course (10%)
  - Add a student to a course (10%)

The service should be designed according to the REST philosophy:
  - using resources (10%)
  - using the HTTP verbs (GET, POST, PUT, DELETE) for different operations (10%)
  - using HTTP status codes correctly (10%). Your code should at least use 404 when requesting a resource which doesn't exist, 201 when creating a resource, 204 when deleting a resource, and 400 (or 412) when trying to create a resource without the required properties.

TODO List:
=================

This list is presented in no particular order.
Please put your name in paranthesis behind the task you are working on.
  - [X] Get a list of courses.
  - [X] Add a course. (Fríða)
    - [X] Auto generate unique ID for courses. (Fríða)
  - [X] Update a course. (Fríða)
    - [ ] Without manually changing ID (Fríða)
  - [X] Delete a course. (Fríða)
  - [X] Get a course with a given ID. (Fríða)
  - [ ] Get a list of students in a course.
  - [ ] Add a student to a course.
  - [ ] Add correct HTTP status codes.
    - [ ] 404 - Resource doesn't exist.
    - [ ] 202 - Resource created.
    - [ ] 204 - Resource deleted.
    - [ ] 400 (412) - Required properties missing.
  - [ ] Clean up and comment code.
    - [ ] Courses.
    - [ ] CoursesRepository.
    - [ ] ICoursesRepository.
    - [ ] CoursesController.


Install Guide:
=================
  - git clone https://github.com/holmfridurge/VEFTassignment1
  - dotnet build
  - dotnet restore
  - doenet watch run