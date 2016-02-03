using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Student
    {
        
        public int NIM { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alamat { get; set; }
        [Required]
        public int umur { get; set; }
    }
}