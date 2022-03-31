using System;
using System.Collections.Generic;

#nullable disable

namespace shoppingAPI_EFCoreDB.Models.EF.Shopping
{
    public partial class ProductDetail
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public string PCategory { get; set; }
        public int? PPrice { get; set; }
        public bool? PIsInStock { get; set; }
        public int? PDiscount { get; set; }
        public string ManufacturedIn { get; set; }
    }
}
