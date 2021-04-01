using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using firstpage.Models;

namespace firstpage.Pages
{
    public class TeachersModel : PageModel
    {
        public List<Teacher> AllTeachers;
        

        public void Teachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher() {Id = 1, Name = "John", ClassId = 1});
            teachers.Add(new Teacher() {Id = 2, Name = "Doe", ClassId = 2});

            AllTeachers = teachers;
        }

     

        public void OnGet()
        {
            Teachers();
            
        }
    }
}