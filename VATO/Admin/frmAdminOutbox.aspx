<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmAdminOutbox.aspx.cs" Inherits="Admin_frmAdminOutbox" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .style5
        {
            font-size: large;
            font-weight: bold;
            color: White;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
  <asp:UpdatePanel ID="panel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="GridInboxdetails" EventName="RowCommand" />
                <asp:AsyncPostBackTrigger ControlID="btnDelete" EventName="Click" />     
            </Triggers>
            <ContentTemplate>
          
        <br />
        <br />
       <asp:Panel ID="mainPanel" runat="server">
        <table width="80%" border="1" style="border-color: #5A5D5A; border-width: 1px;">
            <tr>
                <td bgcolor="#E7B642" style="background-color: #173D15">
                    <br />
                    <center class="style5">
                       &nbsp;OutBox Details </center>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <br />
                   <table width="100%">
                   <tr>
                   <td>
                   <asp:GridView ID="GridInboxdetails" Width="100%" runat="server" CellPadding="4" 
                           ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" 
                           onrowcommand="GridInboxdetails_RowCommand" 
                           onrowdatabound="GridInboxdetails_RowDataBound" EmptyDataText="No Emails " 
                           onselectedindexchanged="GridInboxdetails_SelectedIndexChanged">
                       <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                       <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                       <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                       <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                       <HeaderStyle BackColor="#173D15" Font-Bold="True" ForeColor="White" />
                       <EditRowStyle BackColor="#999999" />
                       <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                       <Columns>
                       <asp:TemplateField ControlStyle-Width="5%" HeaderStyle-Width="5%">
                       <HeaderTemplate>
                     <asp:CheckBox ID="chkSelectAll" runat="server" Text="SelectAll" AutoPostBack="true" OnCheckedChanged="chkSelectAll_CheckedChanged" />
                       </HeaderTemplate>
                       <ItemTemplate>
                       <asp:CheckBox ID="chk1" runat="server" />
                       </ItemTemplate>

<ControlStyle Width="5%"></ControlStyle>
                           <HeaderStyle Width="5%" />
                       </asp:TemplateField>
                       <asp:TemplateField ControlStyle-Width="20%" HeaderText="ReceiverName" >
                       <ItemTemplate>
                       <asp:LinkButton ID="linkSendername"  ForeColor="black" runat="server" Text='<%#Eval("UserName") %>' CommandArgument='<%#Eval("EmailId") %>'></asp:LinkButton> 
                       <asp:Label ID="lblReadstatus" runat="server" Text='<%#Eval("EmailReadStatus") %>' Visible="false"></asp:Label>
                       <asp:Label ID="lblid" runat="server" Text='<%#Eval("EmailId") %>' Visible="false"></asp:Label>
                       </ItemTemplate>

<ControlStyle Width="20%"></ControlStyle>
                       </asp:TemplateField>
                           <asp:TemplateField ControlStyle-Width="50%" ItemStyle-Width="50%" HeaderText="Subject">
                       <ItemTemplate>
                       <asp:LinkButton  ID="linksubject" runat="server"  ForeColor="black" Text='<%#Eval("emailsubjecttext") %>' CommandArgument='<%#Eval("EmailId") %>'></asp:LinkButton> 
                       </ItemTemplate>

<ControlStyle Width="50%"></ControlStyle>
                               <ItemStyle Width="50%" />
                       </asp:TemplateField>
                        <asp:TemplateField ControlStyle-Width="25%" HeaderText="Date">
                       <ItemTemplate>
                       <asp:LinkButton  ID="linkDate" runat="server"  ForeColor="black" Text='<%#Eval("Date") %>' CommandArgument='<%#Eval("EmailId") %>'></asp:LinkButton>
                       </ItemTemplate>

<ControlStyle Width="25%"></ControlStyle>
                       </asp:TemplateField>
                       </Columns>
                       </asp:GridView>
                   </td>
                   </tr>
                   <tr>
                   <td align="left">
                   <table style="text-align:left">
                   <tr>
                   <td align="left">
                   <asp:Button ID="btnDelete" runat="server" Text="Delete" onclick="btnDelete_Click" /> 
                   </td>
                   </tr>
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
                        <asp:Label ID="lblMsg" runat="server" Visible="False"></asp:Label></center>
                </td>
            </tr>
            <tr>
                <td bgcolor="#E7B642" style="background-color: #173D15">
                    <br />
                </td>
            </tr>
        </table>
        </asp:Panel>
        <br />
        <br />
        <center>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        <div id="Progress" runat="server" style="background-color: Gray; font-weight: bold; font-family: Verdana; font-size: medium;width:300px;height:auto;vertical-align:middle">
                        <center>
                            Processing......<br />
                            <img src="../Images/Process.gif" height="100px" width="100px" />
                        </center>
                        </div>
                        <cc1:AlwaysVisibleControlExtender TargetControlID="Progress"  HorizontalSide="Center" VerticalSide="Middle" ID="AlwaysVisibleControlExtender1" runat="server">
                        </cc1:AlwaysVisibleControlExtender>
                    </ProgressTemplate>
                </asp:UpdateProgress>
        </center>       
        <br />
        <br />
         </ContentTemplate>
        </asp:UpdatePanel>
    </center>
</asp:Content>

