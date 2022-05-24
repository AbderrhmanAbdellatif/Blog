﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired();
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(100);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a=>a.ViewsCount).IsRequired();
            builder.Property<int>(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreateData).IsRequired();
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(c => c.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");
           // builder.HasData(
           // new Article { 
           // Id=1,
           // CategoryId=1,
           // Title="c# 9.0 ve .net 5 Yenilikleri",
           // Content= "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
           // Thumbnail="Default.jpg",
           // SeoDescription= "c# 9.0 ve .net 5 Yenilikleri",
           // SeoTags="C# , C# 9 ,.net,.net6",
           // SeoAuthor="ABDELRHMAN",
           // Date=DateTime.Now,
           //  IsActive = true,
           //  IsDeleted = false,
           //  CreatedByName = "InitialCreate",
           //   CreateData = DateTime.Now,
           //  ModifiedByName = "InitialCreate",
           //  ModifedData = DateTime.Now,
           //  UserId=1,
           //  Note= "c# 9.0 ve .net 5 Yenilikleri",
           //  ViewsCount=100,
           //  CommentCount=1,


           // },
           // new Article
           // {
           //     Id = 2,
           //     CategoryId = 2,
           //     Title = "cpp 11 ve 19 Yenilikleri",
           //     Content= "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir",
           //     Thumbnail = "Default.jpg",
           //     SeoDescription = "cpp 11 ve 19 Yenilikleri",
           //     SeoTags = "Cpp , Cpp 9 ,cpp and c",
           //     SeoAuthor = "ABDELRHMAN",
           //     Date = DateTime.Now,
           //     IsActive = true,
           //     IsDeleted = false,
           //     CreatedByName = "InitialCreate",
           //     CreateData = DateTime.Now,
           //     ModifiedByName = "InitialCreate",
           //     ModifedData = DateTime.Now,
           //     UserId = 1,
           //     Note = "cpp 11 ve 19 Yenilikleri",
           //     ViewsCount = 200,
           //     CommentCount = 1,
           // }, 
           // new Article
           // {
           //     Id = 3,
           //     CategoryId = 3,
           //     Title = "python 4 ve 3 Yenilikleri",
           //     Content= "Python is a high-level, interpreted, general-purpose programming language. Its design philosophy emphasizes code readability with the use of significant indentation. Python is dynamically-typed and garbage-collected.",
           //     Thumbnail = "Default.jpg",
           //     SeoDescription = "python 4 ve 3 Yenilikleri",
           //     SeoTags = "python, python3 ,python4 and c",
           //     SeoAuthor = "ABDELRHMAN",
           //     Date = DateTime.Now,
           //     IsActive = true,
           //     IsDeleted = false,
           //     CreatedByName = "InitialCreate",
           //     CreateData = DateTime.Now,
           //     ModifiedByName = "InitialCreate",
           //     ModifedData = DateTime.Now,
           //     UserId = 1,
           //     Note = "python 4 ve 3 Yenilikleri",
           //     ViewsCount = 300,
           //     CommentCount = 1,
           // },
           // new Article
           // {
           //     Id = 4,
           //     CategoryId = 4,
           //     Title = "js 4 ve 3 Yenilikleri",
           //     Content= "JavaScript, often abbreviated JS, is a programming language that is one of the core technologies of the World Wide Web, alongside HTML and CSS. Over 97% of websites use JavaScript on the client side for web page behavior, often incorporating third-party libraries",
           //     Thumbnail = "Default.jpg",
           //     SeoDescription = "js 4 ve 3 Yenilikleri",
           //     SeoTags = "js, js fsmvu ",
           //     SeoAuthor = "ABDELRHMAN",
           //     Date = DateTime.Now,
           //     IsActive = true,
           //     IsDeleted = false,
           //     CreatedByName = "InitialCreate",
           //     CreateData = DateTime.Now,
           //     ModifiedByName = "InitialCreate",
           //     ModifedData = DateTime.Now,
           //     UserId = 1,
           //     Note = "js 4 ve 3 Yenilikleri",
           //     ViewsCount = 400,
           //     CommentCount = 1,
           // }
           //);
        }
    }
}
