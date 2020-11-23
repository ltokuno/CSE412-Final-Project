using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CSE412_Group17.dal {

    class DBSelector {
        private string connectionString = Properties.Settings.Default.DBConnString;

        

        public T getRow<T>(string sql) {

            T output;
            
            using (var connection = new NpgsqlConnection(connectionString)) {
                output = connection.QueryFirst<T>(sql);
            }

            return output;
           
        } //end getRow()

        public List<T> getRows<T>(string sql) {

            List<T> output;

            using (var connection = new NpgsqlConnection(connectionString)) {
                output = connection.Query<T>(sql).ToList();
            }

            return output;

        } //end getRows()

    } //end class
} 
