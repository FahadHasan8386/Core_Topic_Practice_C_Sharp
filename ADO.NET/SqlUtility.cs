using Microsoft.Data.SqlClient;
using System.Data;

namespace ADO.NET
{
    public class SqlUtility
    {
        private const string ConnectionString = "Server=Fahad\\SQLEXPRESS;Database=CSharp;User Id=csharpb22;password=123456;Trust Server Certificate=True;";

        // ১. ExecuteNonQuery: Insert, Update, Delete এর জন্য
        public void ExecuteSql(string sql, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Dictionary থেকে প্যারামিটারগুলো লুপ চালিয়ে কমান্ডে যোগ করা
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        // ২. ExecuteQuery: Select বা ডেটা পড়ার জন্য
        public DataTable ExecuteQuery(string sql, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}