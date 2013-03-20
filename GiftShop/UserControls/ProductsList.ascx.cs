using System;

using DataAccess.ProductCatalog;

namespace GiftShop.UserControls
{
    public partial class ProductsList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateControls();
        }

        private void PopulateControls()
        {
            string departmentId = Request.QueryString["DepartmentID"];
            string categoryId = Request.QueryString["CategoryID"];
            string page = Request.QueryString["Page"];

            if (page == null)
            {
                page = "1";
            }

            int howManyPages = 1;
            string pagerFormat = "";

            if (categoryId != null)
            {
                list.DataSource = CatalogAccess.GetProductsInCategory(categoryId, page, out howManyPages);
                list.DataBind();

                pagerFormat = Utilities.LinkFactory.ToCategory(departmentId, categoryId, "{0}");
            }
            else if (departmentId != null)
            {
                list.DataSource = CatalogAccess.GetProductsOnDeptPromo(departmentId, page, out howManyPages);
                list.DataBind();

                pagerFormat = Utilities.LinkFactory.ToDepartment(departmentId, "{0}");
            }
            else
            {
                list.DataSource = CatalogAccess.GetProductsOnFrontPromo(page, out howManyPages);
                list.DataBind();

                pagerFormat = Utilities.LinkFactory.ToCatalogPage("{0}");
            }

            topPager.Show(int.Parse(page), howManyPages, pagerFormat, false);
            bottomPager.Show(int.Parse(page), howManyPages, pagerFormat, true);
        }
    }
}