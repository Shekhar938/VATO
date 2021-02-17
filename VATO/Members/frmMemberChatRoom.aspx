<%@ Page Language="C#" MasterPageFile="~/Members/MembersMasterPage.master" AutoEventWireup="true"
    CodeFile="frmMemberChatRoom.aspx.cs" Inherits="Faculty_frmFacultyChat" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        #Table3
        {
            width: 462px;
        }
        .style1
        {
            color: #FFFFFF;
            font-weight: bold;
            font-size: large;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <table width="100%">
            <tr>
                <td width="40%" valign="top">
                    <br />
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                     <Triggers >
                     <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="" />
                     </Triggers>
                        <ContentTemplate>
                            <table width="100%">
                                <tr>
                                <td>Volunteers<b> available to chat</b></td>
                                </tr>
                                <tr>
                                    <td align="left" style="text-align: center">
                                        <asp:GridView ID="grdFaculty" runat="server" Width="150px" BackColor="White" BorderColor="#CCCCCC"
                                            BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" 
                                            GridLines="Horizontal">
                                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                                 <tr>
                                <td>Donors<b> available to chat</b></td>
                                </tr>
                                <tr>
                                    <td align="left" style="text-align: center">
                                        <asp:GridView ID="grdStudents" runat="server" Width="150px" BackColor="White" BorderColor="#CCCCCC"
                                            BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                            <asp:Timer ID="Timer1" runat="server" ontick="Timer1_Tick" Interval="200">
                            </asp:Timer>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td width="60%" valign="top">
                    <br />
                    <div>
                        <table id="Table3" cellspacing="0" cellpadding="1" border="0" align="center" bgcolor="#52595A">
                            <tr>
                                <td class="style1">
                                    Chat Room
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <iframe style="border-right: orange 2px solid; border-top: orange 2px solid; border-left: orange 2px solid;
                                        width: 450px; border-bottom: orange 2px solid; height: 250px; background-color: #ffffcc"
                                        src="../TheChatScreenWin.aspx" >Chat</iframe>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    Message:
                                    <asp:TextBox ID="TB_ToSend" runat="server" Width="300px" TabIndex="1"></asp:TextBox>
                                    <asp:Button ID="BT_Send" runat="server" Text="Send" Width="80px" CssClass="button1"
                                        TabIndex="2" OnClick="BT_Send_Click"></asp:Button>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                    </div>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        
    </center>
</asp:Content>
