using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceCode.Models
{
    public class Post
    {
        public Post(string title, string language, string code)
        {
            this.title = title;
            this.language = language;
            this.code = code;
        }

        public int postID { get; set; }
        public string title { get; set; }
        public string language { get; set; }
        public string  code { get; set; }
    }
}