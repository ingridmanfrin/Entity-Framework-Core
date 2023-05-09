using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TesteEFBlogging.Models;

namespace TesteEntityframework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCriar_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new DbBlogContext())
            {
                //var blog = new Blog() { Url = ""};
                var blog = new Blog();
                blog.Url = "http://blogs.msdn.com/adonet";  //faz o mesmo que //var blog = new Blog() { Url = ""}; porém este último é mais proficional e permite que seja colocado uma vírgula 
                                                            //e colocar mais propriedades, que icluem todas as propriedades que estiverem dentro de blog no caso deste exemplo
                context.Blogs.Add(blog);
                context.SaveChanges();
                MessageBox.Show("Criado com sucesso!");
            }

        }

        private void btnLer_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new DbBlogContext())
            {
                var blog = context.Blogs.OrderBy(b => b.BlogId).First();    //var blog = context.Blogs.Where(b => b.BlogId == 1).First();
                MessageBox.Show(blog.Url);
            }
        }

        private void BtnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new DbBlogContext())
            {
                var blog = context.Blogs.OrderBy(b => b.BlogId).First();
                blog.Url = "teste";
                context.Blogs.Update(blog);
                context.SaveChanges();
                MessageBox.Show(blog.Url);
            }
        }

        private void btnDeletar_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new DbBlogContext())
            {
                var blog = context.Blogs.OrderBy(b => b.BlogId).First();
                context.Remove(blog);
                context.SaveChanges();
                MessageBox.Show("Blog removido com sucesso!");
            }
        }

        private void btnCriarPost_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new DbBlogContext())
            {
                var blog = context.Blogs.OrderBy(b => b.BlogId).First();
                context.Posts.Add(new Post { Title = "Oi", Content = "Conteúdo", BlogId = blog.BlogId });
                context.SaveChanges();
                MessageBox.Show("Post Adicionado com Sucesso!");
            }
        }
    }
}