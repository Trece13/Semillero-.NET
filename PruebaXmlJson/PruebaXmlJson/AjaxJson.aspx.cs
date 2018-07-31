using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaXmlJson
{
    public partial class AjaxJson : System.Web.UI.Page
    {
        Service1 s1 = new Service1();

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = s1.ObtenerXml();
        }

        protected void Xml_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox1.Text = s1.ObtenerXml();
 
        }

        protected void Json_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox1.Text = s1.ObtenerJson();

        }
    }
}