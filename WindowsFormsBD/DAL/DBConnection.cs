using System.Data.SqlClient;

namespace WindowsFormsBD.DAL
{
    public class DBConnection
    {
        private readonly string ConnStr = "Server=46.183.118.102,54321;Database=PauEmpleados;User Id=sa;Password=Sql#123456789;TrustServerCertificate=true";
        private SqlConnection Conn;

        public DBConnection()
        {
            Conn = new SqlConnection(ConnStr);
        }

        public SqlConnection Connection => Conn;

        public void Open()
        {
            if (Conn.State != System.Data.ConnectionState.Open)
                Conn.Open();
        }

        public void Close()
        {
            if (Conn.State != System.Data.ConnectionState.Closed)
                Conn.Close();
        }
    }
}