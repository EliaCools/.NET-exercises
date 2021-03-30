using System;

namespace bankProgram
{
    public class Client
    {
        private string name;
        private int id;
        private DateTime dateJoined;
        
        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        
        public DateTime _dateJoined
        {
            get { return dateJoined; }
            set { dateJoined = value; }
        }


        public Client()
        {
            
        }

    }
}