using FaceCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceCode.DAO
{
    public class PostDAO
    {
        public void AddPost(Post post)
        {
            using (var context = new FaceCodeContext())
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }
        }

        public IList<Post> ListPosts()
        {
            using (var context = new FaceCodeContext())
            {
                IList<Post> posts = context.Posts.ToList();
                return posts;
            }                      
        }
    }
}