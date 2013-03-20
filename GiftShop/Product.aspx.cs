using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DataAccess.ProductCatalog;
using DataAccess;

namespace GiftShop
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string productId = Request.QueryString["ProductID"];

            ProductDetails pd = CatalogAccess.GetProductDetails(productId);

            if (pd.Name != null)
            {
                PopulateControls(pd);
            }
        }

        private void PopulateControls(ProductDetails pd)
        {
            titleLabel.Text = pd.Name;
            descriptionLabel.Text = pd.Description;
            priceLabel.Text = String.Format("{0:c}", pd.Price);
            productImage.ImageUrl = "ProductImages/" + pd.Image;

            this.Title = GiftShopConfiguration.SiteName + " " + pd.Name;
        }
    }
}