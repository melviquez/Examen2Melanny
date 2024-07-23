using Examen2Melanny.modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2Melanny.tabs
{
    public partial class registrar_casas : System.Web.UI.Page
    {
        //creamos el objeto ubicado en modulos.manejo_datos
        Manejo_datos manejo_datos = new Manejo_datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //llenammos el grid
                manejo_datos.LlenarGrid("select * from casa_noble", grid_casas_nobles);
            }

        }

        protected void click_on_anadir(object sender, EventArgs e)
        {
            //metemos datos al database y actualizamos grid
            manejo_datos.InsertarDatos($"INSERT INTO casa_noble VALUES ('{field_casa.Text}','{field_lord.Text}')");
            manejo_datos.LlenarGrid("select * from casa_noble", grid_casas_nobles);

        }

        protected void click_on_borrar(object sender, EventArgs e   )
        {
            //borramos datos y actualizamos grid
            manejo_datos.BorrarDatos(field_casa.Text);
            manejo_datos.LlenarGrid("select * from casa_noble", grid_casas_nobles);
        }
    }
}