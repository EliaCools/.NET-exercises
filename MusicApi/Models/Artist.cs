using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace TodoApi.Models
{
    public class Artist
    {
        public long Id { get; set; }
        
        public string Name { get; set; }
        
        public string Country { get; set; }
        
    }
}