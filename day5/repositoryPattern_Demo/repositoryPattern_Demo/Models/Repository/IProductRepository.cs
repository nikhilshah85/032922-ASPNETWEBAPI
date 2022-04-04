using System.Collections.Generic;
namespace repositoryPattern_Demo.Models.Repository
{
    public interface IProductRepository
    {
        List<Products> GetAllProducts();
        Products GetProductById(int id);
        Products GetProductByName(string name);
        int GetTotalProducts();

        string getOffer();

    }
}
