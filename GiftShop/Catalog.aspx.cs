using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DataAccess;
using DataAccess.ProductCatalog;

namespace GiftShop
{
    public partial class Catalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateControls();
        }

        private void PopulateControls()
        {
            string departmentId = Request.QueryString["DepartmentID"];
            string categoryId = Request.QueryString["CategoryID"];

            if (categoryId != null)
            {
                CategoryDetails cd = CatalogAccess.GetCategoryDetails(categoryId);
                catalogTitleLabel.Text = HttpUtility.HtmlEncode(cd.Name);

                DepartmentDetails dd = CatalogAccess.GetDepartmentDetails(departmentId);
                catalogDescriptionLabel.Text = HttpUtility.HtmlEncode(cd.Description);

                this.Title = HttpUtility.HtmlEncode(GiftShopConfiguration.SiteName + ": " + dd.Name + ": " + cd.Name);
            }
            else if (departmentId != null)
            {
                DepartmentDetails dd = CatalogAccess.GetDepartmentDetails(departmentId);
                catalogTitleLabel.Text = HttpUtility.HtmlEncode(dd.Name);
                catalogDescriptionLabel.Text = HttpUtility.HtmlEncode(dd.Description);

                this.Title = HttpUtility.HtmlEncode(GiftShopConfiguration.SiteName + ": " + dd.Name);
            }
        }
    }
}