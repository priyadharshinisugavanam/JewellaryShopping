<%@ Page Title="" Language="C#" MasterPageFile="~/WelcomePage.Master" AutoEventWireup="true" CodeBehind="AdminWorkSite.aspx.cs" Inherits="JewellaryShopping.AdminWorkSite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="WelcomePage" runat="server">
    <div>
            <span  >
            <table  class="boxes" Align="Center" border="0">
                   
              <tr>  
                   <td Align="Center">  
                        <asp:Button text="View Customer" runat="server" ID="View"  style="background-color:aliceblue" onclick="ViewCustomer"/></td>
                  </tr>
                
            </table>
           </span>

</div>

</asp:Content>
