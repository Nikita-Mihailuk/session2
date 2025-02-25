using Npgsql;
using System.Data;

namespace sess2
{
    public class DBHelper
    {
        private static string connStr = "Host=localhost:5432;Username=postgres;password=00000000;Database=sess1";

        public static DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (var command = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
