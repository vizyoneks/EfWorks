using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfWorks.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }
    }

    public class Blog
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public Category Category { get; set; }
    }

}
