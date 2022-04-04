using repositoryPattern_Demo.Models.Repository;
using System.Collections.Generic;

namespace repositoryPattern_Demo.Models.SQLServer
{
    public class ProductSQlServer : IProductRepository
    {
        public List<Products> GetAllProducts()
        {
            //connect to database and get the product, use EF Core, 
            //we will pass a dummy data consideting it is comming frfom the database

            return new List<Products>() {

             new Products(){ pId= 501, pName="SQL Server 1", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
             new Products(){ pId= 502, pName="SQL Server 2", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
             new Products(){ pId= 503, pName="SQL Server 3", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
             new Products(){ pId= 504, pName="SQL Server 4", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
             new Products(){ pId= 505, pName="SQL Server 5", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },
             new Products(){ pId= 506, pName="SQL Server 6", pCategory = "SQL Server", pIsAvailable = true, pPrice = 20 },

            };
        }

        public string getOffer()
        {
            return "SQL Server offers are closed as for now, as it is summer ";
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
