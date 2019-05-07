using System;
using System.Data;
using System.Data.SqlClient;
using _4_Shared;

namespace _3_Infra.Context
{
    public class Store_Context : IDisposable
    {
        public SqlConnection Connection { get;set; }
        public Store_Context(){
            Connection = new SqlConnection(Settings.ConnectionStrings);
            Connection.Open();
        }
        public void Dispose()
        {
           if(Connection.State != ConnectionState.Closed)
               Connection.Close();
        }
    }
}