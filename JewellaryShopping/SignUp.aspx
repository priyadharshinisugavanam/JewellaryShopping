<%@ Page Title="" Language="C#" MasterPageFile="~/WelcomePage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="JewellaryShopping.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="WelcomePage" runat="server">
     <table  class="boxs" Align="Center" border="0" / >
                   
               <tr>  
                  <td colspan="2" Align="Center" > <b>Registration form</b></td>
                      
                </tr>
                <tr>  
                    <td>User Id</td>  
                    <td>  
                        <asp:TextBox ID="userId" runat="server" placeholder="User Id"  style="background-color:aliceblue"></asp:TextBox>  </td> 
                        <td><asp:RequiredFieldValidator runat="server" ID="rfvName" ControlToValidate="userId" ErrorMessage="Name required"></asp:RequiredFieldValidator >
                              <asp:RegularExpressionValidator ID="validateName" runat="server" ControlToValidate="userId" ErrorMessage="Enter valid UserId" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                        </ td >
                   


               </tr>
                <tr>
                    <td>Password</td>
                     <td> <asp:TextBox ID="password" runat="server" placeholder=" password" style="background-color:aliceblue"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator runat="server" ID="rvfPassword" ControlToValidate="password" ErrorMessage="Password required"></asp:RequiredFieldValidator></td>
                </tr>  
                <tr>  
                    <td>Confirm Password</td>  
                    <td>  
                        <asp:TextBox ID="conformPassword" runat="server" placeholder="Re-Enter the password"   style="background-color:aliceblue"></asp:TextBox></td>
                        <td><asp:RequiredFieldValidator runat="server" ID="rvfConfirmPassword" ControlToValidate="conformPassword" ErrorMessage="Confirm Password required"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ControlToValidate="conformPassword" ControlToCompare="password" ErrorMessage="Password doesn't match" ID="cmpPassword" runat="server"></asp:CompareValidator></td>
                      
                </tr> 
                   

                <tr>  
                    <td>Phone</td>  
                    <td>
                        <asp:TextBox ID="phone" runat="server" placeholder="Phone number"  style="background-color:aliceblue"></asp:TextBox> </td>
                         <td><asp:RequiredFieldValidator runat="server" ID="rvfPhoneNumber" ControlToValidate="phone" ErrorMessage="Phone number required"></asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="rgvMobileNumber" runat="server" ControlToValidate="phone" ErrorMessage="Enter valid mobile number" ValidationExpression="^[6789]\d{9}$"></asp:RegularExpressionValidator>
                         </td>
                       
                   
                </tr>  
                
                <tr>  
                    <td>Gmail</td>  
                    <td>  
                        <asp:TextBox ID="mail" runat="server" placeholder ="Mail ID" TextMode="Email" style="background-color:aliceblue"></asp:TextBox>  
                         <td><asp:RequiredFieldValidator runat="server" ID="rvfEmail" ControlToValidate="mail" ErrorMessage="Email required"></asp:RequiredFieldValidator></td>
                    </td>  
                </tr> 
                <tr>  
                    <td colspan="2" Align="Center">  
                        <asp:Button text="SignUp" runat="server" ID="ButtenSubmit"  style="background-color:aliceblue" onclick="SignUps"/></td>
                     
                </tr>  
            </table>
</asp:Content>
