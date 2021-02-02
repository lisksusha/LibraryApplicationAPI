

namespace LibraryApplicationAPI.Models
{
    public class BookAuthor : BaseEntity
    {
        public int bookid { get; set; }
        public Book Book { get; set; }
        public int authorid { get; set; }
        public Author Author { get; set; }
    }
}
