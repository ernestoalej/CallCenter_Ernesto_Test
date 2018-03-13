using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CallCenterTest.WSCallCenter;

namespace CallCenterTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               
        }


        public void obtenerClientesPagos(string cedula)
        {

            SCallCenterClient client = new SCallCenterClient();

            Cliente[] corr = client.ConsultaPagosCliente(cedula);

            grClientesPagos.DataSource = corr;

            grClientesPagos.DataBind();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            string cedula = txtCedula.Text.Trim();


            obtenerClientesPagos(cedula);
        }
    }
}