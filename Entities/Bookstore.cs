namespace BookstoreManagement.Entities
{
    public class Bookstore : EntityBase
    {
        public Client IdClient { get; set; }  = default!;
        public Client NameClient { get; set; } = default!;
        public List<Book> Books { get; set; } = [];
    }
}
