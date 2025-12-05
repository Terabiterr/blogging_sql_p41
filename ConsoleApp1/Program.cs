using ConsoleApp1.Services;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogService(new BloggingContext()))
            {
                //db.AddBlog(new Blog { Name = "A new blog " });
                string sql = @"
                CREATE TRIGGER DeletePostAfterBlogDeletion
                ON Blogs
                AFTER DELETE
                AS
                BEGIN
                DELETE FROM Posts WHERE BlogId = (SELECT deleted.BlogId FROM deleted);
                END";
                db.CreateTrigger(sql);
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
