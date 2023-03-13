using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Articulo
    {

        [KEY]
        public int ArticuloID { get; set; }
        public int ArticuloName { get; set; }
        

    }
}
