
namespace firstpage.Models
{
    public class Teacher
    {
        private int id;
        private string name;
        private int classId;

        //getstudentobject

       // public async void getstudents()
       // {
       //     
//
//
       // }


        public int Id
        {
            get { return id; }
            set { id = value;  }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int ClassId
        {
            get { return classId; }
            set { classId = value; }
        }
        
        
        
        public Teacher()
        {
        }
        
        



    }
}