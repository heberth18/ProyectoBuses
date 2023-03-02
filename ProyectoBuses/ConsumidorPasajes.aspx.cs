using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoBuses
{
    public partial class ConsumidorPasajes : System.Web.UI.Page
    {
        RS_BD.DataBase_WSSoapClient WS = new RS_BD.DataBase_WSSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = false;
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            String rut = txtId.Text.ToString();
            DataSet ds = WS.ListarPasajes(rut);
            GridView1.Visible = true;
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
    }
}