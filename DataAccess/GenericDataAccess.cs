using System;
using System.Data;
using System.Data.Common;

namespace DataAccess
{
    public static class GenericDataAccess
    {
        static GenericDataAccess()
        {

        }

        public static DataTable ExecuteSelectCommand(DbCommand command)
        {
            DataTable table;

            try
            {
                command.Connection.Open();

                DbDataReader reader = command.ExecuteReader();

                table = new DataTable();
                table.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Utilities.LogError(ex);
                throw;
            }
            finally
            {
                command.Connection.Close();
            }

            return table;
        }

        public static DbCommand CreateCommand()
        {
            string providerName = GiftShopConfiguration.DBProviderName;
            string connectionString = GiftShopConfiguration.DBConnectionString;

            DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);

            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;

            DbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }
    }
}
