
using Microsoft.AspNetCore.Mvc;
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
}