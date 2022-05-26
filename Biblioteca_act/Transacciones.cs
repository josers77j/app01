using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_act
{
    class Transacciones
    {
        //a nivel de atributos se declaran las siguientes variables
        string sql = ""; //para guardar las sql's
        SqlConnection con = new SqlConnection(); //para conectar
        SqlCommand cmd = new SqlCommand();//para ejecutar sql's
                                          //ESTOS OBJETOS, DEBERÍA HABER UNO POR CADA TABLA DE LA BD
        Producto p = new Producto();
        //Cliente c = new Cliente()
        //OtraClase oc = new OtraClase()
        //recordar que hay una clase por tabla de la bd

        // Constructor que inicia la cadena de conexión
        public Transacciones()
        {
            
            this.con.ConnectionString = "Data Source = DESKTOP-RGTGLB4; Initial Catalog = dae;Integrated Security=True";
        }
        //Método para llenar el datgridview
        public DataTable consultar(string tabla)
        {
            DataTable datos = new DataTable();
            //variable para que usa para llenar de el datasource al datatable
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Dependiendo de la tabla que se manda a llamar, se crea la sql a ejecutar
            switch (tabla)
            {
                case "producto":
                    this.sql = "select= from producto";
                    break;
                case "otra_tabla": 
                    this.sql = " select = from otra_tabla";
                    break;
                default:
                    MessageBox.Show("Error de programación, tabla no existe!");
                    break;
            }
            //Conociendo la sql a ejecutar, ejecutamos
            try
            {
                this.con.Open();// se abre la conexion
                                // se carga el adapter y de una se conecta
                adapter.Fill(datos);//llena datos con el resultado de la consulta
            }
            catch (SqlException error)
            {
                MessageBox.Show("Ocurrio el siguiente error de SQL:" + error.Message);
            }
            finally
            {
                this.con.Close();
            }
            return datos;
        }
        //método personalizado para ejecutar  sql´s de cada transaccion
        private bool ejecutar(string sql)
        {
            //Este método ejecuta cualquier sql y retorna true o false dependiendo si se da o no
            //la sql es la que viene como parámetro
            try
            {
                this.cmd.CommandText = sql;// Definimos el sql a ejecutar
                this.cmd.Connection = this.con;// el cmd toma la configuracion de conexion
                this.cmd.Connection.Open();//se abre ña conexión
                this.cmd.ExecuteNonQuery();// se ejecuta la sql guardada en cmd
                return true;
            }
            catch (SqlException error)
            {
                MessageBox.Show("Error de SQL:" + error.Message);
                return false;

            }
            finally
            {
                this.cmd.Connection.Close();//se cierra la conexion activa
            }
        }
        public bool insertar(object objDatos, string tabla)
        {
            //Dependiendo de la tabla se genera la sql
            switch (tabla)
            {
                case "producto":
                    this.p = (Producto)objDatos;// casting
                    this.sql = "insert into producto(nombre_prod, costo_prod, id_proveedor, cantidad) values('" + p.nombre_prod + "', " + p.costo_prod + ", " + p.id_proveedor + ", " + p.cantidad + ")";
                    break;
                case "otraTabla":
                    //this.otroObjeto = (OtraClase)objDatos;//casting
                    this.sql = "insert into otraTabla values....";
                    break;
                default:
                    MessageBox.Show("No se ingresaron datos, error de programación");
                    break;
            }
            if (ejecutar(this.sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool modificar(object objDatos, string tabla)
        {
            switch (tabla)
            {
                case "producto":
                    this.p = (Producto)objDatos;
                    this.sql = "update producto set nombre_prod= ' " + p.nombre_prod + "'costo_prod=" + p.cantidad + "where id_prod=" + p.id_prod;
                    break;
                default:
                    MessageBox.Show("No se ingresaron datos, error de programación");
                    break;
            }
            if (ejecutar(this.sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool eliminar(string tabla, string campoID, string valorID)
        {
            string sql = "delete from" + tabla + "where" + campoID + "=" + valorID;
            if (ejecutar(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
