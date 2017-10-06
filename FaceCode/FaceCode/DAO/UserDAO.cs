using FaceCode.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaceCode.DAO
{
    public class UserDAO
    {

        public void Add(User user)
        {
            using (var context = new FaceCodeContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public User Find (string email , string password)
        {
            using (var context = new FaceCodeContext())
            {
                return context.Users.FirstOrDefault(user =>
                user.email == email && user.password == password);
            }
        }        
        
    }
}