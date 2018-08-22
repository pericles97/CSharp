
using System.Data.Entity;

namespace CodeFirst.Model.DAL {
    public class Contexto : DbContext{

        public Contexto() : base("nomeStringConexao") {

        }

        //Tabelas que sarão criadas no banco
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }



    }
}
