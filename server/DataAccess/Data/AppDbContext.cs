using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Models.Entities;

namespace DataAccess.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var random = new Random();
            var posts = Enumerable.Range(1, 15).Select(i => new Post
            {
                Id = i,
                Title = $"Post {i}",
                Description = $"Beskrivning för post {i}",
                Image = $"image{i}.jpg",
                Created = DateTime.Now.AddDays(-random.Next(1, 30)).Date,
                LastEdited = DateTime.Now.AddDays(-random.Next(1, 30)).Date
            }).ToList();

            modelBuilder.Entity<Post>().HasData(posts);
        }
    }
}
