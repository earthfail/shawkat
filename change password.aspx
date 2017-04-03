<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.master" AutoEventWireup="true" CodeFile="change password.aspx.cs" Inherits="change_password" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style97 {
        width: 100%;
        height: 131px;
            margin-left: 94px;
        }
    .auto-style111 {
        width: 146px;
        height: 50px;
    }
    .auto-style112 {
            height: 50px;
        }
    .auto-style106 {
        text-align: center;
        width: 157px;
        height: 69px;
    }
    .auto-style102 {
        text-align: center;
        width: 152px;
        height: 69px;
    }
    .auto-style99 {
        text-align: left;
        height: 69px;
    }
        .auto-style113 {
            text-align: center;
            width: 157px;
            height: 50px;
            color: #FFFFFF;
        }
        .auto-style115 {
            text-align: center;
            width: 157px;
            height: 50px;
            color: #FEFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style97">
        <tr>
            <td class="auto-style113" style="text-align: center">Email</td>
            <td class="auto-style111" colspan="2">
                <asp:TextBox ID="TextBox1" runat="server" style="text-align: center" TextMode="Email" Width="143px"></asp:TextBox>
            </td>
            <td class="auto-style112"></td>
        </tr>
        <tr>
            <td class="auto-style115">Old Password</td>
            <td class="auto-style111" colspan="2">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="144px"></asp:TextBox>
            </td>
            <td class="auto-style112"></td>
        </tr>
        <tr>
            <td class="auto-style113">New Passord</td>
            <td class="auto-style111" colspan="2">
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="144px"></asp:TextBox>
            </td>
            <td class="auto-style112"></td>
        </tr>
        <tr>
            <td class="auto-style106"></td>
            <td class="auto-style102">
                <asp:Button ID="Button1" runat="server" Text="Change" Width="103px" OnClick="Button1_Click" style="height: 26px" />
            </td>
            <td class="auto-style99" colspan="2">
                <asp:Label ID="Label1" runat="server" style="color: #FFFFFF; font-size: xx-large" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    </asp:Content>

