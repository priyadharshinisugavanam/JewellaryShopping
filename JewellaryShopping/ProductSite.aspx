<%@ Page Title="" Language="C#" MasterPageFile="~/WelcomePage.Master" AutoEventWireup="true" CodeBehind="ProductSite.aspx.cs" Inherits="JewellaryShopping.ProductSite" %>
<asp:Content ID="customer" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="customerSite" ContentPlaceHolderID="WelcomePage" runat="server">
       <asp:GridView ID="customerProduct" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductNumber">
        <Columns>
            
          <asp:TemplateField HeaderText="ProductNumber" runat="server">
               <EditItemTemplate>
                    <asp:TextBox ID="ProductNumber" runat="server" Text='<%# Bind("ProductNumber") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="NumberLabel" runat="server" Text='<%# Bind("ProductNumber") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Product" runat="server">
                <EditItemTemplate>
                    <asp:TextBox ID="Product" runat="server" Text='<%# Bind("productName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("productName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="Rate" runat="server">
                <EditItemTemplate>
                    <asp:TextBox ID="Rate" runat="server" Text='<%# Bind("productRate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="RateLabel" runat="server" Text='<%# Bind("productRate") %>'></asp:Label>
                </ItemTemplate>
               
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
</asp:Content>
