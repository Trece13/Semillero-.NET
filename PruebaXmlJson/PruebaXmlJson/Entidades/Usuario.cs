using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PruebaXmlJson.Entidades
{
    [DataContract(Name = "persona", Namespace = "http://schemas.contoso.com")]
    [Serializable]
    public class Usuario
    {
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "apellido")]
        public string Apellido { get; set; }
        [DataMember(Name = "telefono")]
        public int Telefono { get; set; }
    }
}