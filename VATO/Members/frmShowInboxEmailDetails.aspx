<%@ Page Language="C#" MasterPageFile="~/Members/MembersMasterPage.master" AutoEventWireup="true" CodeFile="frmShowInboxEmailDetails.aspx.cs" Inherits="Members_frmShowInboxEmailDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style5
        {
            font-size: large;
            font-weight: bold;
            color: White;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <br />
        <br />
        <table width="80%" border="1" style="border-color: #5A5D5A; border-width: 1px;">
            <tr>
                <td bgcolor="#E7B642" style="background-color: #173D15">
                    <br />
                    <center class="style5">
                        Mail Details
                    </center>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td align="left">
                    <h4>
                        <a href=frmInbox.aspx>Back</a>
                    </h4>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <table width="100%">
                        <tr>
                            <td>
                                <asp:GridView ID="GridInboxdetails" Width="100%" runat="server" CellPadding="4" ForeColor="#333333"
                                    GridLines="None" AutoGenerateColumns="False" OnRowCommand="GridInboxdetails_RowCommand">
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#173D15" Font-Bold="True" ForeColor="White" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <table style="text-align: left">
                                                    <tr>
                                                        <td>
                                                            Subject :
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtSubject" Text='<%#Eval("emailsubjecttext") %>' runat="server"
                                                                Width="350px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Body :
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtBody" runat="server" Height="100px" Text='<%#Eval("emailbodymsg") %>'
                                                                TextMode="MultiLine" Width="350px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Attach File :
                                                        </td>
                                                        <td>
                                                            <asp:LinkButton ID="linkAttach" Text='<%#Eval("EmailAttachFileName") %>' CommandArgument='<%#Eval("Emailid") %>'
                                                                runat="server">
                                                            </asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <table style="text-align: left">
                                </table>
                            </td>
                        </tr>
                    </table>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <center>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label></center>
                </td>
            </tr>
            <tr>
                <td bgcolor="#E7B642" style="background-color: #173D15">
                    <br />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
    </center>
</asp:Content>

