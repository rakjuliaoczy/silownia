<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Silownia.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  
    <title>Sample Registration Page</title>  
    <style type="text/css">  
        .style1 {  
            width: 100%;  
        }  
    </style>  
</head>  
<body>  
    <form id="form1" runat="server">  
        <div class="row">  
            <table class="style1">  
                <tr>  
                    <td>Full Name:</td>  
                    <td>  
                        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Username:</td>  
                    <td>  
                        <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Password:</td>  
                    <td>  
                        <asp:TextBox ID="TxtPassword" runat="server"  
                                     TextMode="Password"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Re Password:</td>  
                    <td>  
                        <asp:TextBox ID="TxtRePassword" runat="server"  
                                     TextMode="Password"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Address:</td>  
                    <td>  
                        <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Age:</td>  
                    <td>  
                        <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Gender:</td>  
                    <td>  
                        <asp:DropDownList ID="DropDownList1" runat="server"  
                                          AppendDataBoundItems="true">  
                            <asp:ListItem Value="-1">Select</asp:ListItem>  
                            <asp:ListItem>Male</asp:ListItem>  
                            <asp:ListItem>Female</asp:ListItem>  
                        </asp:DropDownList>  
                    </td>  
                </tr>  
            </table>  
        </div>  
        <asp:Button ID="btnsave" CssClass="btn-btn-primary" width="200" runat="server" Text="Save" />
                      
    </form>  
</body>  
</html>  
