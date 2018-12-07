using EfWorks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfWorks.Repositories
{
    public class BlogDB : DbContext
    {
        public BlogDB(DbContextOptions<BlogDB> options)
       : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasKey(x => x.Id);
            }
            );

        }


        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
