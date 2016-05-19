using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBasics.Models
{
    public class BookMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, MinimumLength = 2)]
        public string Author { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(100)]
        public string Title { get; set; }

        [RegularExpression(@"^ISBN\s(?=[-0-9xX ]{13}$)(?:[0-9]+[- ]){3}[0-9]*[xX0-9]$", ErrorMessage = "Invalid ISBN.")]
        public string Isbn { get; set; }
    }
}