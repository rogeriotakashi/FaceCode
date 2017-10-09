using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FaceCode.Models;

namespace FaceCode.DAO
{
    public class FaceCodeContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        public FaceCodeContext() : base("FaceCodeDb")
        {
        }
    }
}