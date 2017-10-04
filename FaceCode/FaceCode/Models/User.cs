using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FaceCode.Models
{
    public class User
    {
        public int UserID { get; set; }

        [StringLength(50)]
        [Index(IsUnique=true)]
        public string username { get; set; }
        public string password { get; set; }

    }
}