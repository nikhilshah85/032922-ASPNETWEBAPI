using repositoryPattern_Demo.Models.Repository;
using System.Collections.Generic;

namespace repositoryPattern_Demo.Models.Collections
{
    public class ProductCollection : IProductRepository
    {

        static List<Products> products = new List<Products>()
        {
            new Products(){ pId= 1, pName="Collection Product 1", pCategory = "Collection", pIsAvailable = true, pPrice = 20 },
            new Products(){ pId= 2, pName="Collection Product 2", pCategory = "Collection", pIsAvailable = true, pPrice = 20 },
            new Products(){ pId= 3, pName="Collection Product 3", pCategory = "Collection", pIsAvailable = true, pPrice = 20 },
           new Products(){ pId= 4, pName="Collection Product 4", pCategory = "Collection", pIsAvailable = true, pPrice = 20 },
        };
        public List<Products> GetAllProducts()
        {
            return products;
        }

        public string getOffer()
        {
            return "Great offers on collections";
        }

        public Products GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Products GetProductByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public int GetTotalProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
