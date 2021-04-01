using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstpage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using firstpage.Models;

namespace firstpage.Pages
{
    public class groupsModel : PageModel
    {
        public List<Group> AllGroups;

        private void Groups()
        {
            List<Group> Groups = new List<Group>();
            Groups.Add(new Group(){ GroupId = 1, GroupName = "fun class"});
            Groups.Add(new Group(){ GroupId = 2, GroupName = "funner class"});

            AllGroups = Groups;

        }

        public void OnGet()
        {

            Groups();

        }
    }
}
