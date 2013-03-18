using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DataAccess.ProductCatalog;

namespace GiftShop.UserControls
{
    public partial class CategoriesList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string departmentId = Request.QueryString["DepartmentID"];

            if (departmentId != null)
            {
                list.DataSource = CatalogAccess.GetCategoriesInDepartment(departmentId);
                list.DataBind();
            }
        }
    }
}