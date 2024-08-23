﻿using System.Security.Cryptography.X509Certificates;

namespace APIPROJECT.Models
{

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
