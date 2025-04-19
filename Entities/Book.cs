namespace BookstoreManagement.Entities
{
    public class Book : EntityBase
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public GenreEnum? Genre { get; set; } = default!;
        public decimal? Price { get; set; }
        public int? QuantityStock { get; set; }
    }
}
