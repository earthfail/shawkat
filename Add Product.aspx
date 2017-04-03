<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageadmin.master" AutoEventWireup="true" CodeFile="Add Product.aspx.cs" Inherits="Add_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style97 {
        width: 100%;
        height: 447px;
    }
    .auto-style98 {
        font-size: x-large;
    }
    .auto-style99 {
        color: #FFFFFF;
        text-align: center;
        width: 143px;
    }
    .auto-style100 {
        width: 143px;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style97">
    <tr>
        <td class="auto-style98" colspan="3" style="text-align: center; color: #FFFFFF">Add New Product</td>
    </tr>
    <tr>
        <td class="auto-style99">Product ID</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" Width="136px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style99">Product Name</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox2" runat="server" Width="138px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style99">Price</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox3" runat="server" Width="140px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style99">Category</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style100">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Add" Width="183px" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

