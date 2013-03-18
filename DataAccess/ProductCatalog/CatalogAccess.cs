using System;
using System.Data;
using System.Data.Common;

using DataAccess;

namespace DataAccess.ProductCatalog
{
    public static class CatalogAccess
    {
        static CatalogAccess()
        {

        }

        public static DataTable GetDepartments()
        {
            DbCommand command = GenericDataAccess.CreateCommand();
            command.CommandText = "CatalogGetDepartments";

            return GenericDataAccess.ExecuteSelectCommand(command);
        }

        public static DepartmentDetails GetDepartmentDetails(string departmentId)
        {
            DbCommand command = GenericDataAccess.CreateCommand();
            command.CommandText = "CatalogGetDepartmentDetails";

            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@DepartmentID";
            parameter.Value = departmentId;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(command);

            DepartmentDetails details = new DepartmentDetails();

            if (table.Rows.Count > 0)
            {
                details.Name = table.Rows[0]["Name"].ToString();
                details.Description = table.Rows[0]["Description"].ToString();
            }

            return details;
        }

        public static CategoryDetails GetCategoryDetails(string categoryId)
        {
            DbCommand command = GenericDataAccess.CreateCommand();
            command.CommandText = "CatalogGetCategoryDetails";

            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@CategoryID";
            parameter.Value = categoryId;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(command);

            CategoryDetails details = new CategoryDetails();

            if (table.Rows.Count > 0)
            {
                details.DepartmentID = Int32.Parse(table.Rows[0]["DepartmentID"].ToString());
                details.Name = table.Rows[0]["Name"].ToString();
                details.Description = table.Rows[0]["Description"].ToString();
            }

            return details;
        }

        public static ProductDetails GetProductDetails(string productId)
        {
            DbCommand command = GenericDataAccess.CreateCommand();
            command.CommandText = "CatalogGetProductDetails";

            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@ProductID";
            parameter.Value = productId;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(command);

            ProductDetails details = new ProductDetails();

            if (table.Rows.Count > 0)
            {
                DataRow dr = table.Rows[0];

                details.ProductID = int.Parse(productId);
                details.Name = dr["Name"].ToString();
                details.Description = dr["Description"].ToString();
                details.Price = Decimal.Parse(dr["Price"].ToString());
                details.Thumbnail = dr["Thumbnail"].ToString();
                details.Image = dr["Image"].ToString();
                details.PromoFront = bool.Parse(dr["PromoFront"].ToString());
                details.PromoDept = bool.Parse(dr["PromoDept"].ToString());
            }

            return details;
        }

        public static DataTable GetCategoriesInDepartment(string departmentId)
        {
            DbCommand command = GenericDataAccess.CreateCommand();
            command.CommandText = "CatalogGetCategoriesInDepartment";

            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@DepartmentID";
            parameter.Value = departmentId;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            return GenericDataAccess.ExecuteSelectCommand(command);
        }

        public static DataTable GetProductsOnFrontPromo(string pageNumber, out int howManyPages)
        {
            DbCommand command = GenericDataAccess.CreateCommand();
            command.CommandText = "CatalogGetProductsOnFrontPromo";

            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@DescriptionLength";
            parameter.Value = GiftShopConfiguration.ProductDescriptionLength;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@PageNumber";
            parameter.Value = pageNumber;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@ProductsPerPage";
            parameter.Value = GiftShopConfiguration.ProductsPerPage;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@HowManyProducts";
            parameter.Direction = ParameterDirection.Output;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(command);

            int howManyProducts = Int32.Parse(command.Parameters["@HowManyProducts"].Value.ToString());
            howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)GiftShopConfiguration.ProductsPerPage);

            return table;
        }

        public static DataTable GetProductsOnDeptPromo(string departmentId, string pageNumber, out int howManyPages)
        {
            DbCommand command = GenericDataAccess.CreateCommand();
            command.CommandText = "CatalogGetProductsOnDeptPromo";

            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@DepartmentID";
            parameter.Value = departmentId;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@DescriptionLength";
            parameter.Value = GiftShopConfiguration.ProductDescriptionLength;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@PageNumber";
            parameter.Value = pageNumber;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@ProductsPerPage";
            parameter.Value = GiftShopConfiguration.ProductsPerPage;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@HowManyProducts";
            parameter.Direction = ParameterDirection.Output;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(command);

            int howManyProducts = Int32.Parse(command.Parameters["@HowManyProducts"].Value.ToString());
            howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)GiftShopConfiguration.ProductsPerPage);

            return table;
        }

        public static DataTable GetProductsInCategory(string categoryId, string pageNumber, out int howManyPages)
        {
            DbCommand command = GenericDataAccess.CreateCommand();
            command.CommandText = "CatalogGetProductsInCategory";

            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@CategoryID";
            parameter.Value = categoryId;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@DescriptionLength";
            parameter.Value = GiftShopConfiguration.ProductDescriptionLength;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@PageNumber";
            parameter.Value = pageNumber;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@ProductsPerPage";
            parameter.Value = GiftShopConfiguration.ProductsPerPage;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@HowManyProducts";
            parameter.Direction = ParameterDirection.Output;
            parameter.DbType = DbType.Int32;

            command.Parameters.Add(parameter);

            DataTable table = GenericDataAccess.ExecuteSelectCommand(command);

            int howManyProducts = Int32.Parse(command.Parameters["@HowManyProducts"].Value.ToString());
            howManyPages = (int)Math.Ceiling((double)howManyProducts / (double)GiftShopConfiguration.ProductsPerPage);

            return table;
        }
    }
}
