using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_act
{
    public partial class Form1 : Form
    {
        Transacciones obj_Trans = new Transacciones();
        Producto obj_prod = new Producto();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            obj_prod.nombre_prod = txt_nom.Text;
            obj_prod.costo_prod = double.Parse(txt_costo.Text);
            obj_prod.id_proveedor = int.Parse(txt_idprov.Text);
            obj_prod.cantidad = int.Parse(txtcant.Text);
            obj_Trans.insertar(obj_prod, "producto");
        }
    }
}