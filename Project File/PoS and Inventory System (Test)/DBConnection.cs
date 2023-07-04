using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS_and_Inventory_System__Test_
{
    internal class DBConnection
    {

        public string MyConnection()
        {
            string con = "Data Source=(LocalDb)\\LocalDBPoS;Initial Catalog=\"Point of Sale\";Integrated Security=True";
            return con;
        }
    }
}
