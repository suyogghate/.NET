namespace CRUDAppUsingADO
{
    public static class ConnectionString
    {
        private static string connStr = "Server=LAPTOP-5T9AA23T\\SQLEXPRESS;Database=CrudADOdb;Trusted_Connection=True;";

        public static string dbcs { get => connStr; }

    }
}
