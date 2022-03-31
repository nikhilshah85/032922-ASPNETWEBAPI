using System;
using System.Collections.Generic;

#nullable disable

namespace shoppingAPI_EFCoreDB.Models.EF.Shopping
{
    public partial class Customer
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string CCity { get; set; }
        public int? CWalletBalance { get; set; }
        public string CType { get; set; }
    }
}
