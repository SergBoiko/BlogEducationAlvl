﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public int AuthorId { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public List<CommentModel> Comments { get; set; }
    }
}