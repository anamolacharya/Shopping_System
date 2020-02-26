<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Master.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <td><table>
        <tr>
            <td>Product Name :</td>
            <td><asp:TextBox ID="txtname" runat="server" Text="Flower Bouquet"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Price :</td>
            <td><asp:TextBox ID="TextBox1" runat="server" Text="$24.99+tax"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsave" runat="server" Text="BUY"></asp:Button></td>
        </tr>
    </table>
</td>
</asp:Content>
