using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Basic
{
    public class SqlHelper
    {
        private static string ConnectionString
        {
            //get {return BaseConfigFactory.GetDBConnectString;}
            //get {return "server=127.0.0.1;database=HndEdu;uid=wordbyword;pwd=wbw@com@cn;";}
            //get { return "server=127.0.0.1;database=HND;uid=test;pwd=test;"; }
            //get { return System.Configuration.ConfigurationManager.AppSettings["strConnectSql"]; }
            get { return ConfigurationManager.ConnectionStrings["Job_ConnectionString"].ConnectionString; }
            //get {return "server=127.0.0.1;database=HND;uid=sa;pwd=sa;";}
            //get {return "server=127.0.0.1;database=HND;uid=ruchnd;pwd=r@u@c#h#n#d;";}
            //get {return ConfigurationSettings.AppSettings[BaseConfigFactory.GetTablePrefix+"DBConnectString"] ;}
            //get {return ConfigurationSettings.AppSettings["DNT_DBConnectString"];}
        }


        public static DataSet ExecuteDataset(string ConnectionString,int intListBegin, int intPageSize, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Call the overload that takes a connection in place of the connection string
                return SqlDB.ExecuteDataset(intListBegin, intPageSize, connection, commandType, commandText, commandParameters);
            }
            //return ExecuteDataset(intListBegin, intPageSize, ConnectionString, commandType, commandText, commandParameters);
        }


        /// <summary>
        /// 执行ExecuteScalar,将结果以字符串类型输出。
        /// </summary>
        /// <param name="connectionString">数据库连接串</param>
        /// <param name="commandType">查询命令类型(text,StoredProcedure,TableDirect)</param>
        /// <param name="commandText">查询语句</param>
        /// <param name="commandParameters">查询语句所使用的参数</param>
        /// <returns>返回字符型结果</returns>
        public static string ExecuteScalarToStr(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            object ec = ExecuteScalar(ConnectionString, commandType, commandText, commandParameters);
            if (ec == null)
            {
                return "";
            }
            return ec.ToString();
        }

        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            if (connectionString == null || connectionString.Length == 0) throw new ArgumentNullException("connectionString");
            // Create & open a SqlConnection, and dispose of it after we are done
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Call the overload that takes a connection in place of the connection string
                return ExecuteScalar(connection, commandType, commandText, commandParameters);
            }
        }

        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            if (connection == null) throw new ArgumentNullException("connection");

            // Create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();

            bool mustCloseConnection = false;
            PrepareCommand(cmd, connection, (SqlTransaction)null, commandType, commandText, commandParameters, out mustCloseConnection);

            // Execute the command & return the results
            object retval = cmd.ExecuteScalar();

            // Detach the SqlParameters from the command object, so they can be used again
            cmd.Parameters.Clear();

            if (mustCloseConnection)
                connection.Close();

            return retval;
        }

        private static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, out bool mustCloseConnection)
        {
            if (command == null) throw new ArgumentNullException("command");
            if (commandText == null || commandText.Length == 0) throw new ArgumentNullException("commandText");

            // If the provided connection is not open, we will open it
            if (connection.State != ConnectionState.Open)
            {
                mustCloseConnection = true;
                connection.Open();
            }
            else
            {
                mustCloseConnection = false;
            }

            // Associate the connection with the command
            command.Connection = connection;

            // Set the command text (stored procedure name or SQL statement)
            command.CommandText = commandText;

            // If we were provided a transaction, assign it
            if (transaction != null)
            {
                if (transaction.Connection == null) throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
                command.Transaction = transaction;
            }

            // Set the command type
            command.CommandType = commandType;

            // Attach the command parameters if they are provided
            if (commandParameters != null)
            {
                AttachParameters(command, commandParameters);
            }
            return;
        }
        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            if (command == null) throw new ArgumentNullException("command");
            if (commandParameters != null)
            {
                foreach (SqlParameter p in commandParameters)
                {
                    if (p != null)
                    {
                        // Check for derived output value with no value assigned
                        if ((p.Direction == ParameterDirection.InputOutput ||
                            p.Direction == ParameterDirection.Input) &&
                            (p.Value == null))
                        {
                            p.Value = DBNull.Value;
                        }
                        command.Parameters.Add(p);
                    }
                }
            }
        }

    }
}