using repositoryPattern_Demo.Models.Repository;
using System.Collections.Generic;

namespace repositoryPattern_Demo.Models.MongoDB
{
    public class ProductsMongoDB : IProductRepository
    {
        public List<Products> GetAllProducts()
        {
            //connect to mongoDB and collect the data, we will fire a dummy 1
            return new List<Products>()
            {
                new Products(){ pId= 701, pName="Mongo DB", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
                new Products(){ pId= 702, pName="Mongo DB", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
                new Products(){ pId= 703, pName="Mongo DB", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
                new Products(){ pId= 704, pName="Mongo DB", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
                new Products(){ pId= 705, pName="Mongo DB", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
            };

        }

        public string getOffer()
        {
            return "MongoDB currently has no offer";
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
