using System.Configuration;

namespace DataAccess
{
    public static class GiftShopConfiguration
    {
        private static string dbConnectionString;
        private static string dbProviderName;

        private readonly static int productsPerPage;
        private readonly static int productDescriptionLength;
        private readonly static string siteName;

        static GiftShopConfiguration()
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["GiftShopConnection"].ConnectionString;
            dbProviderName = ConfigurationManager.ConnectionStrings["GiftShopConnection"].ProviderName;
            productsPerPage = System.Int32.Parse(ConfigurationManager.AppSettings["ProductsPerPage"]);
            productDescriptionLength = System.Int32.Parse(ConfigurationManager.AppSettings["ProductDescriptionLength"]);
            siteName = ConfigurationManager.AppSettings["SiteName"];
        }

        public static string DBConnectionString
        {
            get { return dbConnectionString; }
        }

        public static string DBProviderName
        {
            get { return dbProviderName; }
        }

        public static string MailServer
        {
            get { return ConfigurationManager.AppSettings["MailServer"]; }
        }

        public static string MailUsername
        {
            get { return ConfigurationManager.AppSettings["MailUsername"]; }
        }

        public static string MailPassword
        {
            get { return ConfigurationManager.AppSettings["MailPassword"]; }
        }

        public static string MailFrom
        {
            get { return ConfigurationManager.AppSettings["MailFrom"]; }
        }

        public static bool EnableErrorLogEmail
        {
            get { return bool.Parse(ConfigurationManager.AppSettings["EnableErrorLogEmail"]); }
        }

        public static string ErrorLogEmail
        {
            get { return ConfigurationManager.AppSettings["ErrorLogEmail"]; }
        }

        public static int ProductsPerPage
        {
            get { return productsPerPage; }
        }

        public static int ProductDescriptionLength
        {
            get { return productDescriptionLength; }
        }

        public static string SiteName
        {
            get { return siteName; }
        }
    }
}
