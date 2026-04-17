using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhChiNguyen_233400_DH23TIN02
{
    internal class ChuoiKN
    {
        public static string KN = "Data Source=LAPTOP-F0VP14FJ\\MSSQLSERVER01;Initial Catalog=QUANLYBANTRASUA;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(KN);
        }
    }
}
