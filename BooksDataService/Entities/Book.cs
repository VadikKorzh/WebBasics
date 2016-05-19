using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDataService.Entities
{
    public class Book
    {
        [Key]
        [Column("BookId")]
        public int Id { get; set; }

        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        public virtual Writer Author { get; set; }
    }
}
