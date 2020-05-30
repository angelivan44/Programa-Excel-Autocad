using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Subestaciones
    {
        public string id { get; set; }

        public string codigo_localidad { get; set; }
        public string codigo_interno { get; set; }
        public string numero_sed { get; set; }
        public string codigo_subestacion { get; set; }
        public string bloque { get; set; }
        public double x_subestacion { get; set; }
        public double y_subestacion { get; set; }
        public string numero_fases { get; set; }
        public string tension_mt { get; set; }
        public string potencia { get; set; }
        public string id_subestacion { get; set; }
    }
}
