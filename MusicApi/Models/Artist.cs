using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace TodoApi.Models
{
    public class Artist
    {
        public long Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Country { get; set; }
        
        
        [DataType(DataType.Date)]
        [Required]
        
        public DateTime Birthdate { get; set; }
        

        
    }
}