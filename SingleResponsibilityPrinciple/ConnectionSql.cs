using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SingleResponsibilityPrinciple
{
    public class ConnectionSql
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-PJIG1NN;Initial Catalog=Cinema;Integrated Security=True");

    }
}
