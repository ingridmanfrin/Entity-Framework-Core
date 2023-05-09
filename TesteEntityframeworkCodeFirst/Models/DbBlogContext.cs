using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEFBlogging.Models
{
    public class DbBlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }          //As propriedades DbSet<> representam as entidades do modelo que serão mapeadas para tabelas no banco de dados.                               
        public DbSet<Post> Posts { get; set; }          //Neste caso, temos DbSet para a entidade Blog e para a entidade Post.
        //public string DbPath { get; }

        public DbBlogContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;

            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=ITLNB109;Database=TesteEFBlogging;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

}
