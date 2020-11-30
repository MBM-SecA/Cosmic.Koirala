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
 
    }