using System;
using System.ComponentModel.DataAnnotations;

namespace RazorCrud.Models
{
    public class Album
    {
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 1)]
        [Required]
        
        public string Title { get; set;  }
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        
        public string Artist { get; set;  }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(30, MinimumLength = 3)]
        
        public string genre { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
    }
}