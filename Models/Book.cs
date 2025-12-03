namespace MyFavBookApp.Models
{
    public class Book
    {
        public int id { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public int publicationYear { get; set; }

        public string description { get; set; }

        public string url { get; set; }
         
        public Book()
        {
            
        }
    }
}
