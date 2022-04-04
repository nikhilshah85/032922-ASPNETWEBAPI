namespace repositoryPattern_Demo.Models.Repository
{

    //the model will have only the properies, not methods
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public double pPrice { get; set; }
        public bool pIsAvailable { get; set; }
        public string pCategory { get; set; }
    }
}

