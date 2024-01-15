namespace Post
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var post = new Post
            {
                Id = 001,
                Title = "Test Title",
                Description = "Test",
                PublishingDate = DateTime.Now,
                
            };

            Console.WriteLine(post.Id);
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.PublishingDate);
        }
    }
}