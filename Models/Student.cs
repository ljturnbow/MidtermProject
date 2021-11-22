using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidtermProject.Models
{
    public class Student
    {
        public  int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        [Required]
        public DateTime EnrolledDate { get; set; }
        [Required]
        public int CourseStatus { get; set; }
        [Required]
        public string Grade { get; set; }
    }
}