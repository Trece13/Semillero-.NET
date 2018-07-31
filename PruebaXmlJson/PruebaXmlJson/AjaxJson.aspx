<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeBehind="AjaxJson.aspx.cs" Inherits="PruebaXmlJson.AjaxJson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <style>

        * {
            font-family:'Segoe UI';
            font-size:14px;
        }
        .con{
            width:30%;
        }
        #Xml{
            width:48%;
        }
        #Json{
            width:48%;
        }
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container con">
                        <h3 id="Titulo">Objeto</h3>
            <hr />
         <div class="row">
             <div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Rows="30" Height="215px" BorderColor="Gray" Width="500px" Enabled="False"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>

                <asp:Button ID="Xml" runat="server" Text="Xml" OnClick="Xml_Click" CssClass="btn btn-primary"/>
                <asp:Button ID="Json" runat="server" Text="Json" OnClick="Json_Click" CssClass="btn btn-success" />
            </div>
        </div>
       </div>

    </form>
</body>
</html>
