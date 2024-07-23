using Examen2Melanny.modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2Melanny.tabs
{
    public partial class conteo_votos : System.Web.UI.Page
    {
        //creamos el objeto ubicado en modulos.manejo_datos
        Manejo_datos manejo_datos = new Manejo_datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                manejo_datos.LlenarGrid("select top 1 casa_nombre, total_votos,porcentaje_votos from conteo_lealtad order by total_votos desc", grid_ganador);
                manejo_datos.LlenarGrid("select * from conteo_lealtad",grid_conteo_votos);
            }


        }
    }
}