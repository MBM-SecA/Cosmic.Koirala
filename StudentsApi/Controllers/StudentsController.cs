
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Models;
[Route("students")]
[ApiController]
public class StudentController: ControllerBase
{
    [HttpGet]
    [Route("all")]
public ActionResult GetAllStudents()
{
    var students = new string[] {"Cosmic", "Anusha", "Paras", "Kamal",  "Sandesh"};
   
    if(students == null)
        return NotFound();
    return Ok(students);
}

    [HttpGet]
    [Route("{name}")]
public ActionResult GetAllStudentsById(string name)
{
    var students = new string[] {"Cosmic", "Anusha", "Paras", "Kamal",  "Sandesh"};
    var student = students.Where(x => x == name).FirstOrDefault();
   
    
    if(students == null)
        return NotFound();
    return Ok(student);
}

    [HttpPost]
    [Route("add")]
public ActionResult CreateStudent(Student student)
{
    
    if(student == null)
        return BadRequest();

        return Created("",student);
}

    private void FirstOrDefault()
    {
        throw new NotImplementedException();
    }
}
