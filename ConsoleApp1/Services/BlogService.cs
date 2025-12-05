namespace ConsoleApp1.Services
{
    public interface IBlogService
    {
        public IEnumerable<Blog> GetBlogs();
        public Blog GetBlogById(int id);
        public void AddBlog(Blog blog);
        public void UpdateBlog(int id, Blog blog);
        public void DeleteBlog(int id);
        public void AddPostToBlog(int blogId, Post post);
        public void RemovePostFromBlog(int postId);
        public IEnumerable<Post> GetPostsByBlogId(int blogId);
        public Blog GetBlogByPostId(int postId);
        public IEnumerable<Post> GetPostsLongerThan(int blogId, int contentLength);
        public Dictionary<Blog, int> GetPostCountParBlog();
        public void CreateStoredProcedure(string sql);
        public void CreateTrigger(string sql);
        public void CreateView(string sql);
    }
    public class BlogService : IBlogService
    {
        private readonly BloggingContext _context;
        public BlogService(BloggingContext context)
        {
            _context = context;
        }

        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void AddPostToBlog(int blogId, Post post)
        {
            throw new NotImplementedException();
        }

        public void CreateStoredProcedure(string sql)
        {
            throw new NotImplementedException();
        }

        public void CreateTrigger(string sql)
        {
            throw new NotImplementedException();
        }

        public void CreateView(string sql)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(int id)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public Blog GetBlogByPostId(int postId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Blog> GetBlogs() => _context.Blogs;

        public Dictionary<Blog, int> GetPostCountParBlog()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByBlogId(int blogId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsLongerThan(int blogId, int contentLength)
        {
            throw new NotImplementedException();
        }

        public void RemovePostFromBlog(int postId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(int id, Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
