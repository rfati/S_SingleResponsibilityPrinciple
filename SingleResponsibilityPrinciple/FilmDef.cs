using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SingleResponsibilityPrinciple
{
    public class FilmDef
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string GENRE { get; set; }
        public float POINT { get; set; }
        public bool CATEGOTY { get; set; }
        public string PATH { get; set; }

       
    }
}
