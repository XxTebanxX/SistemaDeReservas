using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservasLaboratorios
{
    internal class conection
    {
        public static SqlConnection Conection()
        {
            SqlConnection cnx = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=reservations;Integrated Security=true");
            cnx.Open();
            return cnx;
        }

    }
}
