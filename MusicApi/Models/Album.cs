using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TodoApi.Models
{
    public class Album
    {
        public long Id { get; set; }
    
        public string name { get; set; }
        
        public string artist{ get; set; }
    }
}