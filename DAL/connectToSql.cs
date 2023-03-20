using System.Data.SqlClient;

namespace DAL
{
    public class connectToSql
    {
        public delegate void SetDataReader_delegate(SqlDataReader reader);
        public delegate object SetResulrDataReader_delegate(SqlDataReader reader);

        public static void RunCommand(string sqlQuery, SetDataReader_delegate func)
        {
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=project;Data Source=DESKTOP-CJRITNR\SQLEXPRESS";
           // string connectionString = @"Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = project; Data Source = DESKTOP - CJRITNR\SQLEXPRESS";
            //ConfigurationManager.AppSettings["connectionString"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = sqlQuery;

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        func(reader);
                    }
                }

            }

        }

        public static object RunCommandResult(string sqlQuery, SetResulrDataReader_delegate func)
        {
            object ret = null;
            string connectionString = @"PIntegrated Security=SSPI;Persist Security Info=False;Initial Catalog=project;Data Source=DESKTOP-CJRITNR\SQLEXPRESS
";
             using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = sqlQuery;

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        ret = func(reader);
                    }
                }

            }

            return ret;
        }

    }
}
