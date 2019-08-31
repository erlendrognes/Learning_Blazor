using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorgramDemo.Models;

namespace BlazorgramDemo.Data
{
    public class PostService
    {
        public static async Task<Post[]> GetData()
        {
            return await GetDataFromTheAmazingStaticServer(); //Http.GetJsonAsync<Post[]>("sample-data/blazorgram_posts.json");
        }

        public static Task<Post[]> GetDataFromTheAmazingStaticServer()
        {
            return Task.FromResult(new [] 
            {
                new Post
                {
                    Id = 1,
                    Posted = new DateTime(2019, 1, 1).ToShortDateString(),
                    Title = "Wow, such a beautiful waterfall",
                    User = "Tobias",
                    Comments = new List<Comment>
                    {
                        new Comment
                        {
                            Author = "Snuskeerlend",
                            Content = "Wow, such water",
                        },
                        new Comment
                        {
                            Author = "Erna Solberg",
                            Content = "Pss, #duskregn"
                        }
                    },
                    Image =
                        "https://s3-us-west-2.amazonaws.com/uw-s3-cdn/wp-content/uploads/sites/6/2017/11/04133712/waterfall.jpg",
                    LikeCount = 321
                },
                new Post
                {
                    Id = 2,
                    Posted = new DateTime(2019, 8, 31).ToShortDateString(),
                    Title = "I'm on a boat motherf***er",
                    User = "Snuskeerlend",
                    Comments = new List<Comment>()
                    {
                        new Comment
                        {
                            Author = "Per",
                            Content = "Husk redningsvest",
                        },
                        new Comment
                        {
                            Author = "Pål",
                            Content = "Kjør pent",
                        },
                        new Comment
                        {
                            Author = "Espen",
                            Content = "Jeg fant, jeg fant",
                        },

                    },
                    Image =
                        "https://www.anyboat.com.au/media/catalog/product/cache/1/image/1000x450/17f82f742ffe127f42dca9de82fb58b1/b/o/boat-hire-on-one-world-8.jpg",
                    LikeCount = 300
                },
                new Post
                {
                    Id = 3,
                    Posted = new DateTime(2019, 1, 11).ToShortDateString(),
                    Title = "Next trip goes here",
                    User = "Roald Amundsen",
                    Comments = new List<Comment>()
                    {
                        new Comment
                        {
                            Author = "Jarle Andøy",
                            Content = "Pssst, bedre på sjøen",
                        }
                    },
                    Image = "https://upload.wikimedia.org/wikipedia/commons/4/4e/Artesonraju3.jpg",
                    LikeCount = 297
                },
                new Post
                {
                    Id = 4,
                    Posted = new DateTime(2019, 1, 1).ToShortDateString(),
                    Title = "Run forest run",
                    User = "Team Ingebreigsten",
                    Comments = null,
                    Image = "https://d2z0k43lzfi12d.cloudfront.net/blog/vcdn271/wp-content/uploads/2018/04/thumbnail_8-tips-beginner_1200x800-1024x683.jpg",
                    LikeCount = 19
                },
                new Post
                {
                    Id = 5,
                    Posted = new DateTime(2019, 9, 2).ToShortDateString(),
                    Title = "Yeah, Gonna buy Greenland",
                    User = "Donald Trump",
                    Comments = new List<Comment>()
                    {
                        new Comment
                        {
                            Author = "Denmark",
                            Content = "Not for sale",
                        }
                    },
                    Image = "https://i2.wp.com/www.occidentaldissent.com/wp-content/uploads/2019/08/ECJCSJtUwAA87nM.jpeg?resize=559%2C381",
                    LikeCount = 52
                }
            });
        }
    }
}
