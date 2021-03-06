
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Data;
using StudentsApi.Models;
[Route("students")]
[ApiController]
public class StudentController: ControllerBase
{
    private readonly StudentContext db;
    public StudentController(StudentContext _db)
    {
        db = _db;
    }
    [HttpGet]
    [Route("all")]
public ActionResult GetAllStudents()
{
    var students =  db.Students.ToList();
   
    if(students == null)
        return NotFound();
    return Ok(students);
}

    [HttpGet]
    [Route("{name}")]
public ActionResult GetAllStudentsById(string Id)
{
    var student = db.Students.Find(Id);
    if(student == null)
        return NotFound("Students not Found");
    return Ok(student);
}

    [HttpPost]
    [Route("add")]
public ActionResult CreateStudent(Student student)
{
    
    if(student == null)
        return BadRequest();
        db.Students.Add(student);
        db.SaveChanges();
        return Created("",student);
}
    [HttpPut]
    [Route("update")]
public ActionResult UpdateStudent(Student student)
{
    
    if(student == null)
        return BadRequest();
        db.Students.Attach(student);
        db.Students.Update(student);
        db.SaveChanges();
        return Created("Updated Student",student);
}

    [HttpDelete]
    [Route("delete")]
public ActionResult RemoveStudent(Student student)
{
    
    if(student == null)
        return BadRequest();
        db.Students.Attach(student);
        db.Students.Remove(student);
        db.SaveChanges();
        var result=$"Removed {student.Name} with id={student.Id}";
        return Ok(result);
}

}
