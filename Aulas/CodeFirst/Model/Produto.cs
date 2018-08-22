using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model {
    class Produto {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Imposto { get; set; }


        //ArrayList<Categoria> produtos = new ArrayList<>();

        //Relacionamento de Produto <--> Categoria
        public int CategoriaID { get; set; }//Chave estrangeira

        public virtual Categoria _Categoria { get; set; }//Propriedade de navegação

    }
}
