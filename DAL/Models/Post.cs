﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateTime { get; set; }
        //public virtual ICollection<Commetnts> Commetnts { get; set; }

        public int CommentId { get; set; }

    }
}
