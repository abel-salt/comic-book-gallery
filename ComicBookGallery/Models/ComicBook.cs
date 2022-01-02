using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int IssueNumber { get; set; }

        public bool Favorite { get; set; }

        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }

        public string DisplayName { get { return Title.Replace(" ", "-").ToLower() + "-" + IssueNumber; } }

    }
}