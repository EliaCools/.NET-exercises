using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace TodoApi.Models
{
    public class Album
    {
        public long Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        
        [Required]
        public string ArtistName{ get; set; }
        
        
        [DataType(DataType.Date)]
        [Required]
        
        public DateTime ReleaseDate { get; set; }


    }
}