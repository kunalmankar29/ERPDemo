<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table>
           <tr>
               <td>User Name :</td>
               <td>
                   <asp:TextBox ID="Txt_Username" runat="server"></asp:TextBox></td>
           </tr>
           <tr>
               <td>Password :</td>
               <td>
                   <asp:TextBox ID="Txt_Password" runat="server"></asp:TextBox></td>
           </tr>
           <tr>
               <td colspan ="2">
                   <asp:Button ID="Btn_Login" runat="server" Text="Login" OnClick="Btn_Login_Click" />
               </td>
              
           </tr>
          
       </table>
    </form>
</body>
</html>
