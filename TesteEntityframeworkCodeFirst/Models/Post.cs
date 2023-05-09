using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEFBlogging.Models
{
    public class Post               //Entity Entidade, é o formato da minha tabela no Banco de Dados
                                       // onde Post será o nome da minha tabela e cada propriedade será cada caluna desta tabela
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
