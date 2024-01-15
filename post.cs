namespace Post
{
    public class Post
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime PublishingDate { get; set; }
        public enum Rating
        
        {
            Bad = 1,
            Good = 2,
            VeryGood = 3,
            Excellent = 4
        }
    }
}