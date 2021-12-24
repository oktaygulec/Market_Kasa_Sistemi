using Market_Kasa_GP_Proje.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_GP_Proje.DatabaseAccess.DatabaseContext
{
    public class DBContext
    {
        public SqlConnection connection { get; private set; }

        public DBContext()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MarketDB.mdf;Integrated Security=True");
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlCommand CreateCommand(string commandText,
                                        CommandType commandType = CommandType.StoredProcedure)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = commandText;
            cmd.CommandType = commandType;

            return cmd;
        }

        public SqlCommand CreateCommand(string commandText,
                                        List<SqlParameter> parameters,
                                        CommandType commandType = CommandType.StoredProcedure)
        {
            SqlCommand cmd = CreateCommand(commandText, commandType);

            cmd.Parameters.AddRange(parameters.ToArray());

            return cmd;
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            OpenConnection();
            object id = cmd.ExecuteScalar();
            CloseConnection();

            return id;
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            OpenConnection();
            int executedRows = cmd.ExecuteNonQuery();
            CloseConnection();

            return executedRows;
        }

        public T GetItem<T> (SqlCommand cmd) where T : IModel
        {
            T item = Activator.CreateInstance<T>();
            
            OpenConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows && reader.Read())
            {
                item.ReadItem(reader);
            }

            CloseConnection();
            return item;
        }

        public List<T> ToList<T>(SqlCommand cmd) where T : IModel
        {
            List<T> items = new List<T>();

            OpenConnection();
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                T item = Activator.CreateInstance<T>();

                if (reader.HasRows)
                {
                    item.ReadItem(reader);
                    items.Add(item);
                }
            }

            CloseConnection();
            return items;
        }
    }
}
