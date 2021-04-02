using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorCrud.Models
{
    public class Game
    {
        
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 2)]
        [Required]
        
        public string Title { get; set; }
        
        [StringLength(60, MinimumLength = 2)]
        
        public string Developer { get; set; }
        
        [StringLength(30, MinimumLength = 3)]
        
        public string Genre { get; set; }
        
        [DataType(DataType.Currency)]
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        
        public Decimal Price { get; set; }
        
        
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        
        public string Rating { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        [Required]
        
        public DateTime ReleaseDate { get; set; }
        
        
      
        
        
    }
}