using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Trabajo3
{
    public partial class Ejercicio3_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //cadena de conexion "personal" a la base de datos Libreria

            /*
    *  NICOLAS - DESKTOP-63S5VJO
    *  CARMEN - DESKTOP-BR8V697
    *  EZEQUIEL - 192.168.0.66
    *  MATEO - MSI\SQLEXPRESS
    String rutaDB = "Data Source=DESKTOP-BR8V697\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";

    String rutaDB Mateo = "Data Source=MSI\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True"
    */

            string rutaDB = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";

            string consulta1 = Request.QueryString["consulta"];

            SqlConnection cn = new SqlConnection(rutaDB);
            cn.Open();

            SqlDataAdapter adap = new SqlDataAdapter(consulta1, cn);

            DataSet ds = new DataSet();

            adap.Fill(ds, "Libros");

            grdLibros.DataSource = ds.Tables["Libros"];
            grdLibros.DataBind();
            cn.Close();

            hypOtroTema.NavigateUrl = "Ejercicio3-1.aspx";

        }
    }
}