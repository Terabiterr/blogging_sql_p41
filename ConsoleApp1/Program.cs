namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
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
