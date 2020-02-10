<%@ Page Title="" Language="C#" Trace="false"  MasterPageFile="~/WelcomePage.Master" AutoEventWireup="true" CodeBehind="AdminWorkSite.aspx.cs" Inherits="JewellaryShopping.AdminWorkSite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="WelcomePage" runat="server">
    <div>
            <span  >
            <table  class="boxes" Align="Center" border="0">
                   
              <tr>  
                   <td Align="Center">  
                        <asp:Button text=" Customer Details" runat="server" ID="View"  style="background-color:aliceblue" onclick="ViewCustomer"/> </td>
                  </tr>
                <tr>  
                   <td Align="Center">  
                        <asp:Button text=" Product Details" runat="server" ID="Button1"  style="background-color:aliceblue" onclick="ViewProduct"/> </td>
                  </tr>
                
            </table>
           </span>

</div>

</asp:Content>
