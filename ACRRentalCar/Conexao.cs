using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ACRRentalCar
{
    public class Conexao
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=;C: \Users\VM estudo\Desktop\ACRRentalCar\ACRRentalCar\ACRRentalCar\DB_RENTALCAR.mdf;Integrated Security=True;Connect Timeout=30");
            return cnn;
        }
    }
}
