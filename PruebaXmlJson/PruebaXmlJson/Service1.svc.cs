using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PruebaXmlJson.Interfaces;
using PruebaXmlJson.Entidades;
using System.Web.Services.Protocols;
using System.Web.Services;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Json;

namespace PruebaXmlJson
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 
    {

        public Usuario ObjetoUsuario()
        {
            Usuario usuario = new Usuario
            {
                Nombre = "juan",
                Apellido = "cubillos",
                Telefono = 2365416
            };

            return usuario;
        }

        public string ObtenerJson()
        {

            Usuario usr = ObjetoUsuario();
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(usr.GetType());
            jsonSerializer.WriteObject(stream1, usr);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);

            return sr.ReadToEnd();

        }

        
        public string ObtenerXml()
        {

            Usuario usr = ObjetoUsuario();
            XmlSerializer xmlSerializer = new XmlSerializer(usr.GetType());
            StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, usr);

            return textWriter.ToString();

        }


    }
}


