using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFDataBaseFirst.Controllers {
    class ProductsController {

        void Inserir(Product prod) {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Product.Add(prod);
            contexto.SaveChanges();
        }

        List<Product> lostOfProducts() {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.ToList();
        }

        Product BuscarPorId(int id) {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.Find(id);
        }

        void DeleteProducts(int id) {
            Product productIsDeleting = BuscarPorId(id);
            if (productIsDeleting != null) {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Product.Remove(productIsDeleting);
            }
        }

        void UpdateProduct(int id, Product newDataProduct) { 
            Product productOld = BuscarPorId(id);
            if (true) {
                productOld.Name = newDataProduct.Name;
                productOld.ProductNumber = newDataProduct.ProductNumber;
                productOld.Color = newDataProduct.Color;

                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Entry(productOld).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        List<Product> BuscarPorName(string nameProd) {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

            //LINQ - Suporte para QUERYES SQL dentro do C#
            //https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b

            //select * from product.name
            var lista = from prod in contexto.Product where prod.Name == nameProd select prod;

            return lista.ToList();
        }

        List<Product> BuscarPorNumber(string numberProd) {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

            //LINQ - Suporte para QUERYES SQL dentro do C#
            //https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b

            //select * from product.productNumber
            var lista = from prod in contexto.Product where prod.ProductNumber == numberProd select prod;

            return lista.ToList();
        }

    }
}
