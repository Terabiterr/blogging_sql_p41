using ConsoleApp1.Services;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogService(new BloggingContext()))
            {
                db.AddBlog(new Blog { Name = "A new blog " });
            }
            using (var db = new BloggingContext())
            {
                var blogs = db.Blogs;
                foreach (var b in blogs)
                {
                    Console.WriteLine(b.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
