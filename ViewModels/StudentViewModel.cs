using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermProject.Models;

namespace MidtermProject.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; } 
        public List<Courses> CourseList { get; set; } 
        public List<CourseStatus> CourseStatuses { get; set; }
    }
}