<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ServicioWeb.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
    <title>Home</title>
    <style type="text/css">
        .l {
            width: 200px;
            border-radius: 25px;
            outline: none;
            border: 2px solid #39c;
        }

        .la {
            width: 250px;
            display: inline-block;
        }

        header {
            text-align: center;
        }

        div {
            margin-left: auto;
            margin-right: auto;
            text-align: center;
            width: 600px;
            margin-top: 25px;
        }

        .met {
            width: 200px;
            height: 20px;
        }
    </style>
</head>
<body>
    <header>
        <h1>Presión Arterial</h1>
        <img src="Imagenes/corazon.jpg" width="200px" alt="none" />
    </header>
    <form id="form1" runat="server">

        <div>
            <asp:Label class="la" ID="Label1" runat="server" Text="Edad:"></asp:Label>
            <asp:TextBox Class="l" ID="edad" runat="server" TextMode="Number" min="1" max="70" placeholder="28" required></asp:TextBox>
            <br />
            <br />
            <asp:Label class="la" ID="Label2" runat="server" Text="Presión Sistolica:"></asp:Label>
            <asp:TextBox Class="l" ID="sistolica" runat="server" TextMode="Number" min="1" max="220" placeholder="120" required></asp:TextBox>
            <br />
            <br />
            <asp:Label class="la" ID="Label3" runat="server" Text="Presión Diastolica:"></asp:Label>
            <asp:TextBox Class="l" ID="diastolica" runat="server" TextMode="Number" min="1" max="220" placeholder="80" required></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="consulta" runat="server" Text="Consultar" OnClick="consulta_Click" class="btn btn-danger" />
            <br />
            <br />
            <h4>Presion Normal</h4>
            <meter class="met" min="1" max="220" value="120" low="105" high="147">vacio</meter>
            <br />
            <h4>Presion muy Baja</h4>
            <meter class="met" min="1" max="220" value="60" low="120" high="147" optimum="120">vacio</meter>
            <br />
            <h4>Presion muy Alta</h4>
            <meter class="met" min="1" max="220" value="220" low="120" high="147">vacio</meter>
            <br />
            <br />
            <hr />
            <h4>Resultado:</h4>
            <asp:Label ID="recibir" runat="server"></asp:Label>
            <br />
            <img src="Imagenes/tabla.png" alt="no imagen" />
        </div>



    </form>



</body>
</html>
