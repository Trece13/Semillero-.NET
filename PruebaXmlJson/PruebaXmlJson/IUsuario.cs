using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;
using PruebaXmlJson.Entidades;
namespace PruebaXmlJson.Interfaces
{
    [ServiceContract]
    public interface IUsuario
    {


        [OperationContract]
        string ObtenerJson();

        [OperationContract]
        string ObtenerXml();

        // TODO: agregue aquí sus operaciones de servicio
    }

}
