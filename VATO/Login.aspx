<%@ Page Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="Untitled Page" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style6
        {
            font-size: large;
            font-weight: bold;
            color: #FFFFCC;
            background-color: #546138;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <br />
       <br />
       <br />
       <br />
        <table width="60%" border="1" style="border-color: #5A5D5A; border-width: 1px;">
            <tr>
                <td bgcolor="#C97536" class="style6">
                    <asp:Label ID="Label1" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <table>
                        <tr>
                            <td style="text-align: right">
                                <b>User Name :</b>
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtUsername" runat="server" Width="160px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ControlToValidate="txtUsername" ID="RequiredFieldValidator1"
                                    runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: left">
                                <b>Password :</b>
                            </td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="160px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ControlToValidate="txtPassword" ID="RequiredFieldValidator2"
                                    runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="3">
                                <asp:Button ID="btnLogin" Text="Log In" runat="server" OnClick="btnLogin_Click" />
                            </td>
                        </tr>
                        </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMsg" runat="server" Style="font-weight: 700; font-size: xx-small;
                        color: #FF3300"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="#C97536" style="background-color: #525F37">
                    <br />
                </td>
            </tr>
        </table>
    </center>
</asp:Content>


