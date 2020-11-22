using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CSE412_Group17.dal {
    class DBModifier {
        private string connectionString = Properties.Settings.Default.DBConnString;

        public void modifyRows(string sql) {

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                connection.Execute(sql);
            }

        } //end modifyRows()
                
    } //end class
}
