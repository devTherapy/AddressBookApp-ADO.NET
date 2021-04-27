using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using NLog;

namespace AddressBook.Data
{
    public abstract class DataAccess
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// A method to execute queries that do not return table data
        /// </summary>
        /// <param name="query"></param>
        /// <param name="inputParameters"></param>
        /// <returns>rows affected</returns>
        public static int QueryExecute(string query, SqlParameter[] inputParameters)
        {
            try
            {
                var connStr =
                    $"Data Source=.;Initial Catalog=AddressBook;Integrated Security=True;";

                using SqlConnection conn = new SqlConnection(connStr);
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddRange(inputParameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                logger.Fatal(e.Message);
                throw;
            }
        }

        /// <summary>
        /// A method to execute methods that returns a data reader which data from table
        /// </summary>
        /// <param name="queries"></param>
        /// <param name="inputParameters"></param>
        /// <returns></returns>
        public static async Task<SqlDataReader> ReadFromDatabase(string queries, SqlParameter[] inputParameters)
        {
            var connStr =
                $"Data Source=.;Initial Catalog=AddressBook;Integrated Security=True;";

            try
            {
                var conn = new SqlConnection(connStr);
                await using var cmd = new SqlCommand(queries, conn);
                cmd.Parameters.Clear();
                if (inputParameters != null)
                {
                    cmd.Parameters.AddRange(inputParameters);

                }

                await conn.OpenAsync();
                var dr = await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                return dr;

            }
            catch (Exception e)
            {
                logger.Fatal(e.Message);
                throw;
            }
        }


        /// <summary>
        /// A method to execute queries that returns a scalar in this case int
        /// </summary>
        /// <param name="query"></param>
        /// <param name="inputParameters"></param>
        /// <returns></returns>
        public static int QueryScalar(string query, SqlParameter[] inputParameters)
        {
            try
            {
                var connStr =
                    $"Data Source=.;Initial Catalog=AddressBook;Integrated Security=True;";

                using SqlConnection conn = new SqlConnection(connStr);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(inputParameters);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                logger.Fatal(e.Message);
                throw;
            }
        }


        /// <summary>
        /// A method to execute ADO transactions
        /// </summary>
        /// <param name="firstQuery"></param>
        /// <param name="firstInputParameters"></param>
        /// <param name="secondQuery"></param>
        /// <param name="secondInputParameters"></param>
        public static void ExecuteTransaction(string firstQuery, SqlParameter[] firstInputParameters,
            string secondQuery, SqlParameter[] secondInputParameters)
        {
            try
            {
                var connStr =
                    $"Data Source=.;Initial Catalog=AddressBook;Integrated Security=True;";
                using SqlConnection conn = new SqlConnection(connStr);
                using SqlCommand cmd1 = new SqlCommand(firstQuery, conn);
                using SqlCommand cmd2 = new SqlCommand(secondQuery, conn);

                cmd1.Parameters.AddRange(firstInputParameters);
                cmd2.Parameters.AddRange(secondInputParameters);

                conn.Open();
                using SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    cmd1.Transaction = trans;
                    cmd2.Transaction = trans;

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    trans.Commit();
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    logger.Error(e.Message);
                    throw;
                }
            }
            catch (Exception e)
            {
                logger.Fatal(e.Message);
                throw;
            }
        }

        public DataTable GetAdapter(string query)
        {
            var connStr =
                $"Data Source=.;Initial Catalog=AddressBook;Integrated Security=True;";
            DataTable dataTable = new DataTable();
            using (SqlConnection connector = new SqlConnection(connStr)) //connect to database
            {
                connector.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                using (adapter.SelectCommand = new SqlCommand(query, connector))
                {
                    adapter.Fill(dataTable);
                   
                }
              
            }
            return dataTable;
        }
        


    }
}
