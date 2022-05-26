using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca_act
{
    internal class Producto
    {
		public int id_prod { get; } //este es autoincrementable no debe haber set
		public string nombre_prod { get; set; }
		public double costo_prod { get; set; }
		public int id_proveedor { get; set; }
		public int cantidad { get; set; }


	}

	
}
