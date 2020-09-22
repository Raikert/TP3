using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Trabajo3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String Servidor = "Data Source=DESKTOP-63S5VJO\\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            //El string dbViajes debe ir con el nombre de servidor de su PC
            /*
             *  NICOLAS - DESKTOP-63S5VJO
             *  CARMEN - DESKTOP-BR8V697
             */

            String dbViajes = Servidor.ToString();
            String consultasql = "select * from Provincias";
            if (!IsPostBack)
            {
                SqlConnection cnViajes = new SqlConnection(dbViajes);
                SqlCommand cmd = new SqlCommand(consultasql, cnViajes);
                cnViajes.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ddlProvi.DataSource = dr;
                ddlProvi.DataTextField = "NombreProvincia";
                ddlProvi.DataValueField = "IdProvincia";
                ddlProvi.DataBind();
                cnViajes.Close();

                cnViajes.Open();
                SqlDataReader dr1 = cmd.ExecuteReader();
                ddlProvF.DataSource = dr1;
                ddlProvF.DataTextField = "NombreProvincia";
                ddlProvF.DataValueField = "IdProvincia";
                ddlProvF.DataBind();
                cnViajes.Close();

                ddlProvi.Items.Insert(0, new ListItem("-- Seleccione Provincia --"));
                ddlProvi.SelectedValue = "0";
                ddlProvF.Items.Insert(0, new ListItem("-- Seleccione Provincia --"));
                ddlProvF.SelectedValue = "0";
            }
        }

        protected void ddlProvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambiar SV
            String dbViajes = Servidor.ToString();
            String consultasqlL;
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cnViajes = new SqlConnection(dbViajes);
            switch (ddlProvi.SelectedItem.Value)
            {
                case "1":
                    consultasqlL = "select * from Localidades where IdProvincia = 1";
                    cmd = new SqlCommand(consultasqlL, cnViajes);
                    cnViajes.Open();
                    dr = cmd.ExecuteReader();
                    ddlLocali.DataSource = dr;
                    ddlLocali.DataTextField = "NombreLocalidad";
                    ddlLocali.DataValueField = "IdLocalidad";
                    ddlLocali.DataBind();
                    cnViajes.Close();
                    ddlProvF.Items.FindByValue("1").Enabled = false;
                    ddlProvF.Items.FindByValue("2").Enabled = true;
                    ddlProvF.Items.FindByValue("3").Enabled = true;
                    break;
                case "2":
                    consultasqlL = "select * from Localidades where IdProvincia = 2";
                    cmd = new SqlCommand(consultasqlL, cnViajes);
                    cnViajes.Open();
                    dr = cmd.ExecuteReader();
                    ddlLocali.DataSource = dr;
                    ddlLocali.DataTextField = "NombreLocalidad";
                    ddlLocali.DataValueField = "IdLocalidad";
                    ddlLocali.DataBind();
                    cnViajes.Close();
                    ddlProvF.Items.FindByValue("1").Enabled = true;
                    ddlProvF.Items.FindByValue("2").Enabled = false;
                    ddlProvF.Items.FindByValue("3").Enabled = true;
                    break;
                case "3":
                    consultasqlL = "select * from Localidades where IdProvincia = 3";
                    cmd = new SqlCommand(consultasqlL, cnViajes);
                    cnViajes.Open();
                    dr = cmd.ExecuteReader();
                    ddlLocali.DataSource = dr;
                    ddlLocali.DataTextField = "NombreLocalidad";
                    ddlLocali.DataValueField = "IdLocalidad";
                    ddlLocali.DataBind();
                    cnViajes.Close();
                    ddlProvF.Items.FindByValue("1").Enabled = true;
                    ddlProvF.Items.FindByValue("2").Enabled = true;
                    ddlProvF.Items.FindByValue("3").Enabled = false;
                    break;

            }
            ddlLocali.Items.Insert(0, new ListItem("--Seleccione Localidad--", "0"));
            ddlLocali.SelectedValue = "0";
        }

        protected void ddlProvF_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambiar SV
            String dbViajes = Servidor.ToString();
            String consultasqlL;
            SqlCommand cmd;
            SqlDataReader dr;
            SqlConnection cnViajes = new SqlConnection(dbViajes);
            switch (ddlProvF.SelectedItem.Value)
            {
                case "1":
                    consultasqlL = "select * from Localidades where IdProvincia = 1";
                    cmd = new SqlCommand(consultasqlL, cnViajes);
                    cnViajes.Open();
                    dr = cmd.ExecuteReader();
                    ddlLocalF.DataSource = dr;
                    ddlLocalF.DataTextField = "NombreLocalidad";
                    ddlLocalF.DataValueField = "IdLocalidad";
                    ddlLocalF.DataBind();
                    cnViajes.Close();
                    break;
                case "2":
                    consultasqlL = "select * from Localidades where IdProvincia = 2";
                    cmd = new SqlCommand(consultasqlL, cnViajes);
                    cnViajes.Open();
                    dr = cmd.ExecuteReader();
                    ddlLocalF.DataSource = dr;
                    ddlLocalF.DataTextField = "NombreLocalidad";
                    ddlLocalF.DataValueField = "IdLocalidad";
                    ddlLocalF.DataBind();
                    cnViajes.Close();
                    break;
                case "3":
                    consultasqlL = "select * from Localidades where IdProvincia = 3";
                    cmd = new SqlCommand(consultasqlL, cnViajes);
                    cnViajes.Open();
                    dr = cmd.ExecuteReader();
                    ddlLocalF.DataSource = dr;
                    ddlLocalF.DataTextField = "NombreLocalidad";
                    ddlLocalF.DataValueField = "IdLocalidad";
                    ddlLocalF.DataBind();
                    cnViajes.Close();
                    break;
            }
            ddlLocalF.Items.Insert(0, new ListItem("--Seleccione Localidad--", "0"));
            ddlLocalF.SelectedValue = "0";
        }
    }
}
    

