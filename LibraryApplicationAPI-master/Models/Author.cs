using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LibraryApplicationAPI.Models
{
    public class Author : BaseEntity
    {
        public int authorid { get; set; }
        public string fname { get; set; }
        [Required]
        public string lname { get; set; }
        public IEnumerable<BookAuthor> bookauthors { get; set; }

        public Author()
        {
            bookauthors = new List<BookAuthor>();
        }
    }
}
