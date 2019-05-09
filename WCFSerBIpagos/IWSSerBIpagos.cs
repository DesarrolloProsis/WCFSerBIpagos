using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFSerBIpagos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSSerBIpagos" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSSerBIpagos
    {
        // TODO: agregue aquí sus operaciones de servicio

        [OperationContract]
        string Consultar(string XMLRequest);

        [OperationContract]
        string Pagar(string XMLRequest);

        [OperationContract]
        string Reversar(string XMLRequest);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Variables
    {
        [DataMember]
        public string Convenio { get; set; }
        [DataMember]
        public string Proveedor { get; set; }
        [DataMember]
        public string CodigoRetorno { get; set; }
        [DataMember]
        public string MensajeRetorno { get; set; }
        [DataMember]
        public string AutorizacionProveedor { get; set; }
        [DataMember]
        public string AutorizacionBanco { get; set; }
        [DataMember]
        public string Iden01 { get; set; }
        [DataMember]
        public string Iden02 { get; set; }
        [DataMember]
        public string Iden03 { get; set; }
        [DataMember]
        public string Iden04 { get; set; }
        [DataMember]
        public string Iden05 { get; set; }
        [DataMember]
        public string Iden06 { get; set; }
        [DataMember]
        public string Val01 { get; set; }
        [DataMember]
        public string Val02 { get; set; }
        [DataMember]
        public string Val03 { get; set; }
        [DataMember]
        public string Val04 { get; set; }
        [DataMember]
        public string Val05 { get; set; }
        [DataMember]
        public string Val06 { get; set; }
    }
}
