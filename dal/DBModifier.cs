using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace CSE412_Group17.dal {
    class DBModifier {
        private string connectionString = Properties.Settings.Default.DBConnString;

        public void modifyRows(string sql) {

            using (var connection = new NpgsqlConnection(connectionString)) {
                connection.Execute(sql);
            }

        } //end modifyRows()
                
    } //end class
}
