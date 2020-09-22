using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Trabajo3
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        String Servidor = "Data Source=DESKTOP-63S5VJO\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
        String Consulta;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            //El string dbViajes debe ir con el nombre de servidor de su PC
            /*
                NICOLAS - DESKTOP-63S5VJO
                CARMEN - DESKTOP-BR8V697
            */
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            String Vacio = "";
            if (txtProducto.Text != Vacio && txtCategoria.Text != Vacio)
            {
                // FILTRA POR LOS 2
                switch (ddlProducto.Text)
                {
                    case "Igual a":
                        switch (ddlCategoria.Text)
                        {
                            case "Igual a":
                                Consulta = "select * from (Productos inner join [Productos por categoría] on Productos.NombreProducto = [Productos por categoría].NombreProducto) inner join Categorías on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría where Productos.IdProducto = " + txtProducto.Text + " and Categorías.IdCategoría = " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                            case "Mayor a":
                                Consulta = "select * from (Productos inner join [Productos por categoría] on Productos.NombreProducto = [Productos por categoría].NombreProducto) inner join Categorías on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría where Productos.IdProducto = " + txtProducto.Text + " and Categorías.IdCategoría > " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                            case "Menor a":
                                Consulta = "select * from (Productos inner join [Productos por categoría] on Productos.NombreProducto = [Productos por categoría].NombreProducto) inner join Categorías on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría where Productos.IdProducto = " + txtProducto.Text + " and Categorías.IdCategoría < " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                        }
                        break;
                    case "Mayor a":
                        switch (ddlCategoria.Text)
                        {
                            case "Igual a":
                                Consulta = "select * from (Productos inner join [Productos por categoría] on Productos.NombreProducto = [Productos por categoría].NombreProducto) inner join Categorías on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría where Productos.IdProducto > " + txtProducto.Text + " and Categorías.IdCategoría = " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                            case "Mayor a":
                                Consulta = "select * from (Productos inner join [Productos por categoría] on Productos.NombreProducto = [Productos por categoría].NombreProducto) inner join Categorías on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría where Productos.IdProducto > " + txtProducto.Text + " and Categorías.IdCategoría > " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                            case "Menor a":
                                Consulta = "select * from (Productos inner join [Productos por categoría] on Productos.NombreProducto = [Productos por categoría].NombreProducto) inner join Categorías on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría where Productos.IdProducto > " + txtProducto.Text + " and Categorías.IdCategoría < " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                        }
                        break;
                    case "Menor a":
                        switch (ddlCategoria.Text)
                        {
                            case "Igual a":
                                Consulta = "select * from (Productos inner join [Productos por categoría] on Productos.NombreProducto = [Productos por categoría].NombreProducto) inner join Categorías on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría where Productos.IdProducto < " + txtProducto.Text + " and Categorías.IdCategoría = " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                            case "Mayor a":
                                Consulta = "select * from (Productos inner join [Productos por categoría] on Productos.NombreProducto = [Productos por categoría].NombreProducto) inner join Categorías on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría where Productos.IdProducto < " + txtProducto.Text + " and Categorías.IdCategoría > " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                            case "Menor a":
                                Consulta = "select * from (Productos inner join [Productos por categoría] on Productos.NombreProducto = [Productos por categoría].NombreProducto) inner join Categorías on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría where Productos.IdProducto < " + txtProducto.Text + " and Categorías.IdCategoría < " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                        }
                        break;
                }
                DataSet seteador = new DataSet();
                SqlConnection conexion = new SqlConnection(Servidor);
                conexion.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(Consulta, conexion);
                adaptador.Fill(seteador, "Productos");
                gvFiltrado.DataSource = seteador.Tables["Productos"];
                gvFiltrado.DataBind();
                conexion.Close();
            }
            else
            {
                if(txtProducto.Text != Vacio && txtCategoria.Text == Vacio)
                {
                    // FILTRA POR PRODUCTO
                    switch (ddlProducto.Text)
                    {
                        case "Igual a":
                            Consulta = "select * from Productos where IdProducto = " + txtProducto.Text + "order by Productos.IdProducto asc";
                            break;
                        case "Mayor a":
                            Consulta = "select * from Productos where IdProducto > " + txtProducto.Text + "order by Productos.IdProducto asc";
                            break;
                        case "Menor a":
                            Consulta = "select * from Productos where IdProducto < " + txtProducto.Text + "order by Productos.IdProducto asc";
                            break;
                    }
                    DataSet seteador = new DataSet();
                    SqlConnection conexion = new SqlConnection(Servidor);
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(Consulta, conexion);
                    adaptador.Fill(seteador, "Productos");
                    gvFiltrado.DataSource = seteador.Tables["Productos"];
                    gvFiltrado.DataBind();
                    conexion.Close();
                }
                else
                {
                    if(txtProducto.Text == Vacio && txtCategoria.Text != Vacio)
                    {
                        // FILTRA POR CATEGORIA
                        switch (ddlCategoria.Text)
                        {
                            case "Igual a":
                                Consulta = "select * from Productos where IdCategoría = " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                            case "Mayor a":
                                Consulta = "select * from Productos where IdCategoría > " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                            case "Menor a":
                                Consulta = "select * from Productos where IdCategoría < " + txtCategoria.Text + "order by Productos.IdProducto asc";
                                break;
                        }
                        DataSet seteador = new DataSet();
                        SqlConnection conexion = new SqlConnection(Servidor);
                        conexion.Open();
                        SqlDataAdapter adaptador = new SqlDataAdapter(Consulta, conexion);
                        adaptador.Fill(seteador, "Producto");
                        gvFiltrado.DataSource = seteador.Tables["Producto"];
                        gvFiltrado.DataBind();
                        conexion.Close();
                    }
                    else
                    {
                        // MUESTRA TODOS
                        Consulta = "select * from Productos order by Productos.IdProducto asc";
                        DataSet seteador = new DataSet();
                        SqlConnection conexion = new SqlConnection(Servidor);
                        conexion.Open();
                        SqlDataAdapter adaptador = new SqlDataAdapter(Consulta, conexion);
                        adaptador.Fill(seteador, "Producto");
                        gvFiltrado.DataSource = seteador.Tables["Producto"];
                        gvFiltrado.DataBind();
                        conexion.Close();
                    }
                }
            }
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            txtProducto.Text = "";
            txtCategoria.Text = "";
            ddlProducto.ClearSelection();
            ddlCategoria.ClearSelection();
            gvFiltrado.DataSource = "";
            gvFiltrado.DataBind();
        }
    }
}