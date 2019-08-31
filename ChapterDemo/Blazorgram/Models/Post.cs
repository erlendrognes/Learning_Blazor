using System.Collections.Generic;

namespace BlazorgramDemo.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Posted { get; set; }
        public string Title { get; set; }
        public string User { get; set; }
        public List<Comment> Comments { get; set; }
        public int LikeCount { get; set; }
        public string Image { get; set; }
    }

    public class Comment
    {
        public string Author { get; set; }
        public string Content { get; set; }
    }
}
