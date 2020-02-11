<%@ Page Title="" Language="C#" MasterPageFile="~/WelcomePage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JewellaryShopping.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="WelcomePage" runat="server">
    <link rel="stylesheet" href="Styles.css" />

    <div>
        <table class="boxes" align="Center" border="0">

            <tr>
                <td colspan="2" align="Center"><b>Registration form</b></td>
            </tr>
            <tr>
                <td>User Id :</td>
                <td>
                    <asp:TextBox ID="userId" runat="server" placeholder="User Id" Style="background-color: aliceblue"></asp:TextBox>
                    <td>
                        <asp:RequiredFieldValidator runat="server" ID="rfvName" class="required" ControlToValidate="userId" ErrorMessage="Name required"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="validateName" class="required" runat="server" ControlToValidate="userId" ErrorMessage="Enter valid UserId" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>
                </td>

            </tr>
            <tr>
                <td>Password :</td>
                <td>
                    <asp:TextBox ID="password" runat="server" placeholder=" password" Style="background-color: aliceblue"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ID="rvfPassword" class="required" ControlToValidate="password" ErrorMessage="Password required"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td colspan="2" align="Center">
                    <asp:Button Text="Login" runat="server" ID="btnSubmit" Style="background-color: aliceblue" OnClick="OnClicks" /></td>

            </tr>

        </table>

    </div>

</asp:Content>
