using System;
using System.Data.SqlClient;

namespace WindowsFormsDB.DAL
{
    public static class DBConnection
    {
        private static readonly string ConnStr = "Server=46.183.118.102,54321;Database=PascalEmployees;User Id=sa;Password=Sql#123456789;TrustServerCertificate=true";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnStr);
        }
    }
}