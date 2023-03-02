using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WS_DB
{
    /// <summary>
    /// Descripción breve de DataBase_WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class DataBase_WS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

      
        [WebMethod]
        public DataSet ListarPasajes(String rut)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=LAPTOP-D9H85IO0\\SQLEXPRESS; Initial Catalog=bd_ProyectoBuses; Integrated Security=True;";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM pasaje INNER JOIN cliente ON  cliente.rut_cliente = pasaje.rut_cliente WHERE cliente.rut_cliente =" + rut, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}
