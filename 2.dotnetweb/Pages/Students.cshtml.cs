using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using firstpage.Models;
using Microsoft.Extensions.WebEncoders.Testing;

namespace firstpage.Pages
{
    
    
    public class StudentModel : PageModel
    {
       public List<Student> AllStudents;

        
        public  void Test()
        {
            List<Student> students = new List<Student>();
            
            students.Add(new Student {id = 1, name = "Elia", classId = 1});
            students.Add(new Student {id = 2, name = "Jeff", classId = 1});
            students.Add(new Student {id = 3, name = "Sam", classId = 2});
            students.Add(new Student {id = 4, name = "Ricardo", classId = 2});

            AllStudents = students;

        }

        public void OnGet()
        {
            Test();
        }

        public string Message { get; set; } = "In page models";

    }
}
