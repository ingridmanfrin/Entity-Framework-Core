using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEFBlogging.Models
{
    public class Blog              //Entity Entidade, é o formato da minha tabela no Banco de Dados
    {
        //public Blog(string url) //Construtor
        //{
        //    Url = url;
        //}

        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new();

        // propriedade de navegação Posts, que é uma coleção de objetos da classe Post. Essa propriedade é usada para estabelecer um relacionamento entre os objetos Blog e Post.
        // Por exemplo, um objeto Blog pode ter muitos objetos Post associados a ele por meio dessa propriedade de navegação.
    }
}
