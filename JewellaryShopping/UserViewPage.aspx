<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserViewPage.aspx.cs" Inherits="JewellaryShopping.UserViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body >
     <h1><marquee> Sri Mathre Jewellers</marquee></h1>
    <form class="box" id="form3" runat="server" style="background-image:url('Images/jewell.jpg')">
        <div >
          
            <table  Align="Center" border="0">
                   
              <tr>  
                    <td Align="Center">  
                        <asp:Button text="SignUp" runat="server" ID="SignUp"  style="background-color:aliceblue" onclick="OnClick"/></td>
                     
                
                 
                    <td  Align="Center">  
                        <asp:Button text="Login" runat="server" ID="Login"  style="background-color:aliceblue" onclick="OnClicks"/></td>
                     
             </tr> 
            </table>
        </div>
    </form>
</body>
</html>
