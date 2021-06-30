using PollosDatabase.Src.Configurations;
using System;
using System.Data.SqlClient;

namespace PollosDatabase.Src.Connection
{
    internal class ConnectionDb
    {
        private static ConnectionDb _connection;
        private SqlConnection _sqlConnection;
        private string _dataSource;
        private string _userName;
        private string _password;
        private string _dataBase;

        private ConnectionDb()
        {
            ReadEnv.Load();
            _dataSource = ConfigDb.dataSource;
            _userName = ConfigDb.userName;
            _password = ConfigDb.password;
            _dataBase = ConfigDb.dataBase;
        }

        private void Build()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = _dataSource;
                builder.UserID = _userName;
                builder.Password = _password;
                builder.InitialCatalog = _dataBase;
                _sqlConnection = new SqlConnection(builder.ConnectionString);
                _sqlConnection.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static ConnectionDb GetInstance()
        {
            if (_connection == null)
            {
                return _connection = new ConnectionDb();
            }

            return _connection;
        }

        internal static SqlConnection OpenConnection()
        {
            GetInstance().Build();

            return GetInstance()._sqlConnection;
        }
    }
}
