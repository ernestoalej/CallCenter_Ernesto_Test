using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfCallCenter
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISCallCenter
    {
        [OperationContract]
        List<Cliente> ConsultaPagosCliente(string clienteCedula);

   
    }

    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string nombreCompleto { get; set; }

        [DataMember]
        public DateTime FechaPago { get; set; }

        [DataMember]
        public float monto { get; set; }
    }

}
