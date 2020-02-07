<%@ Page Title="" Language="C#" MasterPageFile="~/WelcomePage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JewellaryShopping.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="WelcomePage" runat="server">
    <link rel="stylesheet" href="Styles.css" />
    
    <div>
             <table  class="boxes" Align="Center" border="0" >
                   
               <tr>  
                  <td colspan="2" Align="Center" > <b>Registration form</b></td>
                </tr>
                <tr>  
                    <td>User Id :</td>  
                    <td>  
                        <asp:TextBox ID="userId" runat="server" placeholder="User Id"  style="background-color:aliceblue"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Password</td>  
                     <td> <asp:TextBox ID="password" runat="server" placeholder=" password" style="background-color:aliceblue"></asp:TextBox></td>  
                </tr> 
                   
                  <tr>  
                    <td colspan="2" Align="Center">  
                        <asp:Button text="Login" runat="server" ID="btnSubmit"  style="background-color:aliceblue" onclick="OnClicks"/></td>
                     
                </tr>  
                 
                 </table>
        
        </div>
        
</asp:Content>
