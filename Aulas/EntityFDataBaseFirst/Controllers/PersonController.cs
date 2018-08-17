using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFDataBaseFirst.Controllers {
    class PersonController {

        void Inserir(Person p) {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Person.Add(p);
            contexto.SaveChanges();
        }

        List<Person> listOfPerson() {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.ToList();
        }

        Person BuscarPorId(int id) {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.Find(id);//O metodo Find só faz busca pela chave Primaria, ou seja, não busca se a cgave for String
        }

        void DeletePerson(int id) {
            Person personIsDeleting = BuscarPorId(id);
            if (personIsDeleting != null) {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Person.Remove(personIsDeleting);
            }
        }


    }
}
