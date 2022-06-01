using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect22_LA_W3.DL
{
    class DBConnection
    {
        private SqlConnection _con;
        private String _conString;
        public DBConnection()
        {
            _conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BSSE\SCD\Projects\Lect22_LA_W3\Lect22_LA_W3\SCRS_database.mdf;Integrated Security=True";
            _con = new SqlConnection(_conString);
        }

         public SqlConnection Con { get => _con; set => _con = value; }
    }
}
