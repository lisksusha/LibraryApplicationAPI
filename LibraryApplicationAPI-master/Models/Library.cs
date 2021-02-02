using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace LibraryApplicationAPI.Models
{
    public class Library : BaseEntity
    {
        [Key]
        public int libraryid;
        public string libraryname;
        public string address;
        public IEnumerable<Book> books { get; set; }

        public Library()
        {
            books = new List<Book>();
        }
    }
}
