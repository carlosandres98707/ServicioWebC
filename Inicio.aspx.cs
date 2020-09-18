using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServicioWeb
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void consulta_Click(object sender, EventArgs e)
        {
            ServiceReference1.miservicioSoapClient miwebser = new ServiceReference1.miservicioSoapClient();

            recibir.Text = miwebser.presionHarterial(int.Parse(edad.Text), int.Parse(sistolica.Text), int.Parse(diastolica.Text));
           
        }
    }
}