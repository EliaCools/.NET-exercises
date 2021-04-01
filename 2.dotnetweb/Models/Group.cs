namespace firstpage.Models
{
    public class Group
    {
        private int groupId;
        private string groupName;

        public int  GroupId
        {
           get { return groupId; }
           set { groupId = value; }
            
        }

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public Group()
        {
            
        }
        
        
    }
}