using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ProductCatalog
{
    public struct DepartmentDetails
    {
        public string Name;
        public string Description;
    }

    public struct CategoryDetails
    {
        public int DepartmentID;
        public string Name;
        public string Description;
    }

    public struct ProductDetails
    {
        public int ProductID;
        public string Name;
        public string Description;
        public decimal Price;
        public string Thumbnail;
        public string Image;
        public bool PromoFront;
        public bool PromoDept;
    }
}
