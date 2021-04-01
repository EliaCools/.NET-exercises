using System;
using System.Collections.Generic;
namespace firstpage.Models
{

    public class Student 

    {
        private int Id;
        private string Name;
        private int ClassId;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        
         public int classId
        {
            get { return ClassId; }
            set { ClassId = value; }
        }


   
         
         
        // public override bool Equals(object obj)
        // {
        //     if (obj == null) return false;
        //     Student objAsPart = obj as Student;
        //     if (objAsPart == null) return false;
        //     else return Equals(objAsPart);
        // }
        //    
        // public bool Equals(Student other)
        // {
        //     if (other == null) return false;
        //     return (this.id.Equals(other.id));
        // }
         
         
         
         
         
         public Student()
         {
            // id = studentid;
            // name = studentname;
            // classId = studentclassId;

         }

        
        
    }
}
