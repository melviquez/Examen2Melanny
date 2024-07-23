using Examen2Melanny.modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2Melanny.tabs
{
    public partial class registrar_votos : System.Web.UI.Page
    {
        //creamos el objeto ubicado en modulos.manejo_datos
        Manejo_datos manejo_datos = new Manejo_datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //llenammos el grid
                manejo_datos.LlenarDropDown("SELECT casa_nombre FROM casa_noble", dropdown_casas);
                manejo_datos.LlenarGrid("select * from votos_lealtad", grid_votos);
            }
        }

        protected void click_on_anadir_voto(object sender, EventArgs e)
        {
            manejo_datos.InsertarVoto(dropdown_casas);
            manejo_datos.LlenarGrid("select * from votos_lealtad", grid_votos);
        }
    }
}