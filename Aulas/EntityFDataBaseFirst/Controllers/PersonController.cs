using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFDataBaseFirst.Controllers {
    class PersonController {
        AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
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
            return contexto.Person.Find(id);//O metodo Find só faz busca pela chave Primaria, ou seja, não busca se a chave for String
        }

        void DeletePerson(int id) {
            Person personIsDeleting = BuscarPorId(id);
            if (personIsDeleting != null) {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Person.Remove(personIsDeleting);
            }
        }

        void UpdatePerson(int id, Person novoDadosPerson) {
            Person personAntigo = BuscarPorId(id);

            if (true) {
                personAntigo.FirstName = novoDadosPerson.FirstName;
                personAntigo.LastName = novoDadosPerson.LastName;
                personAntigo.Title = novoDadosPerson.Title;

                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Entry(personAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        List<Person> BuscarPorFirstName(string firstName) {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            //LINQ - Suporte para QUERYES SQL dentro do C#
            //https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b

            //select * from person
            /*var lista = from p in contexto.Person select p;*/

            //select * from person.firstName
            var lista = from p in contexto.Person where p.FirstName == firstName select p;

            return lista.ToList();

        }

    }
}
