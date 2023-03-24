using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public  class Banco
    {
        public int IdBanco  { get; set; }
        public string  Nombre { get; set; }
        public int NoEmpleados  { get; set; }
        public int NoSucursales  { get; set; }
        public decimal Capital  { get; set; }
        public int NoClientes  { get; set; }

        //propiedad de navegacion
        public ML.Pais pais { get; set; }
        public ML.RazonSocial razonSocial { get; set; }

        public List<object> Bancos { get; set; }
    }
}
