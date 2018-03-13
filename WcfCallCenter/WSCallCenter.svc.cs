using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WcfCallCenter
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSCallCenter : ISCallCenter
    {
        string cnnString = "";

        public WSCallCenter()
        {
            cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ToString();
        }

        public List<Cliente> ConsultaPagosCliente( string clienteCedula)
        {
            string sql;

            if (clienteCedula.Equals("") )
            {
                sql = "exec ConsultaPagosCliente ''";
            } else
            {
                sql = "exec ConsultaPagosCliente '" + clienteCedula  + "'";
            }
            

            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);

                SqlDataReader dr = cmd.ExecuteReader();

                List<Cliente> Lista = new List<Cliente>();

                while (dr.Read())
                {
                    Cliente cli = new Cliente()
                    {
                        nombreCompleto = dr["nombreCompleto"].ToString(),
                        FechaPago = Convert.ToDateTime(dr["FechaPago"]),
                        monto = Convert.ToSingle(dr["Monto"])
                    };


                    Lista.Add(cli);

                }

                return Lista;
            }








            return null;
        }
    }


}
