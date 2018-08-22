using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model {
    class Categoria {

        [Key]//Informar que esse é o ID caso ao use o nome ID propriamente dito
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Relacionamento Categoria <--> Produto

        //Quando começa com virtual ele não vira uma propriedade na tabela do banco
        public virtual ICollection<Produto> _Produtos { get; set; }
        


    }
}
