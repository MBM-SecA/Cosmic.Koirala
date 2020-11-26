using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }
   
    [Display(Name = "First Name")]
    [Required]

    public string FirstName { get; set; }
    
    [Display(Name = "Last Name")]
    [Required]
    
    public string LastName { get; set; }
    public string Address { get; set; }

    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }
 
    public static List<Person> GetData()
    {//object initializer syntax
        Person emp1 = new Person() {Id = 1, FirstName = "Bishnu", LastName = "Rawal", Address = "Kathmandu", Salary = 20000.0 };
        Person emp2 = new Person() {Id = 2, FirstName = "Paras", LastName = "Tiwari", Address = "Pokhara", Salary = 2000.0 };
        Person emp3 = new Person() {Id = 3, FirstName = "Cosmic", LastName = "Koirala", Address = "Butwal", Salary = 6000.0 };
        Person emp4 = new Person() {Id = 4, FirstName = "Hari", LastName = "Sapkota", Address = "Pokhara", Salary = 2000.0 };
        Person emp5 = new Person() {Id = 5, FirstName = "Sandesh", LastName = "Magar", Address = "Kathmandu", Salary = 5000.0 };
        Person emp6 = new Person() {Id = 6, FirstName = "Kamal", LastName = "pandit", Address = "Kathmandu", Salary = 3000.0 };
        List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4, emp5, emp6 };
        return employees;
    }
 
}