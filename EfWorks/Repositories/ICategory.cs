using EfWorks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfWorks.Repositories
{
    public interface ICategory
    {
        void Add(Category category);

        List<Category> GetCategories();


    }

    public interface IBlog
    {
        void Add(Blog blog);
        List<Blog> GetBlogs();
    }

}
