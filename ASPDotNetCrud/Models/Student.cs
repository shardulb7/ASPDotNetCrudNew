using System;
using System.ComponentModel.DataAnnotations;

namespace ASPDotNetCrud.Models
  {
 
    public class Student
    {
        [Key]//Keynotation
        [Display(Name = "Student 10")]//Decoretor
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }
        [Display(Name="Enrollment Date")]    
        public DateTime EnrollmentDate { get; set; }
    }
}