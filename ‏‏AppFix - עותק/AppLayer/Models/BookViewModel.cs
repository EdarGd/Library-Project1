namespace AppLayer.Models
{
    public class BookViewModel
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string FirstName_Author { get; set; }
        public string LastName_Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Category { get; set; }
        public string SecondaryCategory { get; set; }
    }
}