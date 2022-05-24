using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(1000);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreateData).IsRequired();
            builder.Property(c => c.ModifedData).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Comments");
            //builder.HasData(
            //new Comment {
            // Id=1,
            // ArticleId=1,
            // Text= "This is my favourite",
            // IsActive = true,
            // IsDeleted = false,
            // CreatedByName = "InitialCreate",
            // CreateData = DateTime.Now,
            // ModifiedByName = "InitialCreate",
            // ModifedData = DateTime.Now,
            // Note="c# Makale Yorumu"
            //}, 
            //new Comment{
            //    Id = 2,
            //    ArticleId = 2,
            //    Text = "Lorem ipsum dolor sit amet. Non minus beatae et dolor beatae quo explicabo voluptates aut nihil distinctio sed error nostrum rem nihil quas et quidem voluptatem",
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreateData = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifedData = DateTime.Now,
            //    Note = "cpp Makale Yorumu"
            //}, 
            //new Comment {
            //    Id = 3,
            //    ArticleId = 3,
            //    Text= "Python is a popular programming language. Python can be used on a server to create web applications",
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreateData = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifedData = DateTime.Now,
            //    Note = "python Makale Yorumu"
            //}, 
            //new Comment{
            //    Id = 4,
            //    ArticleId = 4,
            //    Text= "JavaScript is the programming language of the Web. JavaScript is easy to learn. This tutorial will teach you JavaScript from basic to advanced. ",
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreateData = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifedData = DateTime.Now,
            //    Note = "js Makale Yorumu"
            //}
            //);
        }
    }
}
