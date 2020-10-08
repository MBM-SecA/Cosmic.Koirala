using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        Person empl1 = new Person() {FirstName = "Cosmic", Surname = "Koirala", Address="Kapan",Salary = 300.0 };
        Person empl2 = new Person() {FirstName = "Cosmic", Surname = "Koirala", Address="Kapan",Salary = 300.0 };
        Person empl3 = new Person() {FirstName = "Cosmic", Surname = "Koirala", Address="Kapan",Salary = 300.0 };
        Person empl4 = new Person() {FirstName = "Cosmic", Surname = "Koirala", Address="Kapan",Salary = 300.0 };
        Person empl5 = new Person() {FirstName = "Cosmic", Surname = "Koirala", Address="Kapan",Salary = 300.0 };
        List<Person> employees = new List<Person>() {empl1, empl2, empl3, empl4, empl5};
        return View(employees);
    }
}

