<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gestion_Clients.aspx.cs" Inherits="Exercices_de_révision.Gestion_Clients" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 407px;
        }
        .auto-style3 {
            width: 205px;
        }
    </style>
</head>
<body style="height: 259px">
    <form id="form1" runat="server">
        <div style="font-size:30px; text-align:center; font-weight:bold">
            Gestion Clients
        </div>

        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Numéro Compte</td>
                <td>
                    <asp:TextBox ID="TextBox_Num" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Nom</td>
                <td>
                    <asp:TextBox ID="TextBox_Nom" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Prénom</td>
                <td>
                    <asp:TextBox ID="TextBox_Prenom" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Adresse</td>
                <td>
                    <asp:TextBox ID="TextBox_Adressse" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Email</td>
                <td>
                    <asp:TextBox ID="TextBox_Email" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">Mot de passe</td>
                <td>
                    <asp:TextBox ID="TextBox_Pass" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="BynAjouter" runat="server" OnClick="BynAjouter_Click" Text="Ajouter" Width="106px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
