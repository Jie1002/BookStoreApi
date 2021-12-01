namespace BookStoreApi.Models
{
    public enum BookStatus
    {
        InStore,
        Borrowed,
        Lost
    }
    public class Book
    {

        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string? Description { get; set; }
        public string CoverName { get; set; }
        public int Status { get; set; }
    }

}