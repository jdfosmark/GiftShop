using System;
using System.Web;

namespace Utilities
{
    public class LinkFactory
    {
        public static string ToDepartment(string departmentId, string page)
        {
            if (page == "1")
            {
                return BuildAbsolute(String.Format("Catalog.aspx?DepartmentID={0}", departmentId));
            }
            else
            {
                return BuildAbsolute(String.Format("Catalog.aspx?DepartmentID={0}&Page={1}", departmentId, page));
            }
        }

        public static string ToDepartment(string departmentId)
        {
            return ToDepartment(departmentId, "1");
        }

        public static string ToCategory(string departmentId, string categoryId, string page)
        {
            if (page == "1")
            {
                return BuildAbsolute(String.Format("Catalog.aspx?DepartmentID={0}&CategoryID={1}", departmentId, categoryId));
            }
            else
            {
                return BuildAbsolute(String.Format("Catalog.aspx?DepartmentID={0}&CategoryID={1}&Page={2}", departmentId, categoryId, page));
            }
        }

        public static string ToCategory(string departmentId, string categoryId)
        {
            return ToCategory(departmentId, categoryId, "1");
        }

        public static string ToProduct(string productId)
        {
            return BuildAbsolute(String.Format("Product.aspx?ProductID={0}", productId));
        }

        public static string ToProductImage(string filename)
        {
            return BuildAbsolute("/ProductImages/" + filename);
        }

        public static string ToCatalogPage(string page)
        {
            return BuildAbsolute(String.Format("Catalog.aspx?Page={0}", page));
        }

        private static string BuildAbsolute(string relativeUri)
        {
            Uri uri = HttpContext.Current.Request.Url;

            string app = HttpContext.Current.Request.ApplicationPath;

            if (!app.EndsWith("/"))
            {
                app += "/";
            }

            relativeUri = relativeUri.TrimStart('/');

            return String.Format("http://{0}:{1}{2}{3}", uri.Host, uri.Port, app, relativeUri);
        }
    }
}
