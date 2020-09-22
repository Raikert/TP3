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
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //cadena de conexion "personal" a la base de datos Libreria
                /*
                *  NICOLAS - DESKTOP-63S5VJO
                *  CARMEN - DESKTOP-BR8V697
                *  EZEQUIEL - 192.168.0.66   
                *  MATEO - MSI\SQLEXPRESS
                String rutaDB = "Data Source=DESKTOP-BR8V697\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";
                */
                string rutaDB = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";

                string consulta1 = "Select * from Temas";

                SqlConnection cn = new SqlConnection(rutaDB);
                cn.Open();

                SqlCommand cmd = new SqlCommand(consulta1, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                ddlTemas.DataSource = dr;

                ddlTemas.DataTextField = "Tema";
                
                ddlTemas.DataBind();
                
                cn.Close();

            }

            switch (ddlTemas.Text)
            {

                case "Tema 1":
                    hlkLibros.NavigateUrl = "Ejercicio3-2.aspx?consulta=Select * from Libros where IdTema = 1 ";
                    break;
                case "Tema 2":
                    hlkLibros.NavigateUrl = "Ejercicio3-2.aspx?consulta=Select * from Libros where IdTema = 2 ";
                    break;
                case "Tema 3":
                    hlkLibros.NavigateUrl = "Ejercicio3-2.aspx?consulta=Select * from Libros where IdTema = 3 ";
                    break;
                default:
                    break;

            }

        }

    }
}