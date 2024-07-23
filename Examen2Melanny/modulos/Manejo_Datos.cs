using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Examen2Melanny.modulos
{
    public class Manejo_datos
    {
        public void LlenarGrid(string query, GridView grid)
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            grid.DataSource = dt;
                            grid.DataBind();
                        }
                    }
                }
            }
        }

        public void LlenarDropDown(string query, DropDownList dropdown)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dropdown.DataSource = reader;
                    dropdown.DataTextField = "casa_nombre";
                    dropdown.DataBind();
                }
            }
            dropdown.Items.Insert(0, new ListItem("Seleccione una Casa", "0"));
        }

        public void InsertarDatos(string query)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();


        }

        public void BorrarDatos(string casa)
        {
            if (casa != "")
            {
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand($"DELETE casa_noble where casa_nombre = '{casa}'", conexion);
                comando.ExecuteNonQuery();
                conexion.Close();

            }


        }
        public void InsertarVoto(DropDownList dropdown)
        {
            if (dropdown.SelectedIndex > 0)
            {
                string partidoSeleccionado = dropdown.SelectedItem.Text;
                string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO votos_lealtad (casa_nombre) VALUES (@casa_nombre)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@casa_nombre", partidoSeleccionado);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}