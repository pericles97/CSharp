
using System.Data.Entity;

namespace CodeFirst.Model.DAL {
    public class Contexto : DbContext{

        public Contexto() : base("nomeStringConexao") {

        }

        //Tabelas que sarão criadas no banco
        DbSet<Categoria> Categorias { get; set; }

        DbSet<Produto> Produtos { get; set; }



    }
}
