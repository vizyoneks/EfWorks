using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfWorks.Models;

namespace EfWorks.Repositories
{
    public class CategoryRepository : ICategory
    {
        private readonly BlogDB blogDB;

        public CategoryRepository(BlogDB blogDB)
        {
            this.blogDB = blogDB;
        }

        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }
    }

    public class BlogRepository : IBlog
    {
        private readonly BlogDB blogDB;

        public BlogRepository(BlogDB blogDB)
        {
            this.blogDB = blogDB;
        }

        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogs()
        {
            throw new NotImplementedException();
        }
    }
}
