<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmAdminComposeMails.aspx.cs" Inherits="Admin_frmAdminComposeMails" Title="Untitled Page" %>
<%@ Register src="~/UserControls/BrowseFile.ascx" tagname="BrowseFile" tagprefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            font-size: large;
            font-weight: bold;
            color: White;
        }
        .style6
        {
            font-size: x-small;
            color: #FF0000;
            text-align: left;
        }
        .style7
        {
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="panel1" runat="server">

<Triggers>
<asp:AsyncPostBackTrigger ControlID="rdbMembers" EventName="CheckedChanged" />
<asp:AsyncPostBackTrigger ControlID="rdbVolunteers" EventName="CheckedChanged" />
<asp:AsyncPostBackTrigger ControlID="btnSubmit" EventName="Click" />
<asp:PostBackTrigger ControlID="BrowseFile1" />
</Triggers>
<ContentTemplate>


<center>
        <br />
        <br />
        <asp:Panel ID="mainpanel" runat="server">
        <table width="80%" border="1" style="border-color: #5A5D5A; border-width: 1px;">
            <tr>
                <td bgcolor="#E7B642" style="color: #173D15; background-color: #173D15">
                    <br />
                    <center class="style5">
                        Compose Emails Master</center>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <br />
                    <table>
                    <tr>
                    <td>
                    Select Emails :
                    </td>
                    <td colspan="2">
                        Members&nbsp; :
                    <asp:RadioButton ID="rdbMembers" GroupName="rb" runat="server" AutoPostBack="True" oncheckedchanged="rdbMembers_CheckedChanged" 
                             />
                    
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Volunteers :
                    <asp:RadioButton ID="rdbVolunteers" GroupName="rb" runat="server" 
                            AutoPostBack="True" oncheckedchanged="rdbVolunteers_CheckedChanged" 
                             />
                    </td>
                    </tr>
                    <tr>
                            <td style="text-align: left" valign="top">
                                To  :</td>
                            <td style="text-align: left">
                                <asp:DropDownList ID="ddlto" runat="server" Width="350px"></asp:DropDownList>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="ddlto" ErrorMessage="*" 
                                    InitialValue="--Select Emailid--" ForeColor="White"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                            </td>
                        </tr>
                    
                    <tr>
                            <td style="text-align: left" valign="top">
                                Subject  :</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtsubject" runat="server" Width="350px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ControlToValidate="txtsubject" ID="RequiredFieldValidator2"
                                    runat="server" ErrorMessage="*" ForeColor="White"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: left" valign="top">
                                Body&nbsp; :</td>
                            <td style="text-align: left">
                                <asp:TextBox ID="txtbody" runat="server" Height="120px" TextMode="MultiLine" 
                                    Width="350px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ControlToValidate="txtbody" ID="RequiredFieldValidator1"
                                    runat="server" ErrorMessage="*" ForeColor="White"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right">
                                &nbsp;
                            </td>
                            <td style="text-align: left">
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                        <td>
                        Attachment File :
                        </td>
                            <td style="text-align: left" colspan="2" >
                                 
                               
                                <uc1:BrowseFile ID="BrowseFile1" runat="server" />
                               
                            </td>
                            <td>
                            
                            </td>
                            
                        </tr>
                        <tr>
                            <td style="text-align: right" class="style7" colspan="2">
                              
                            </td>
                            <td colspan="2">
                            </td>
                        </tr>
                        <tr>
                            <td class="style6" colspan="2">
                                fields marked with ( * ) are mandetory
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right" colspan="2">
                                <asp:Button ID="btnSubmit" runat="server" Text="Send" OnClick="btnSubmit_Click"
                                    Style="font-weight: 700" />&nbsp;&nbsp;
                                </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                &nbsp;
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
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
    </center>
    <center>
    <asp:UpdateProgress ID="updateprogess1" runat="server">
    <ProgressTemplate>
    <div id="progess" runat="server" style="background-color: Gray; font-weight: bold; font-family: Verdana; font-size: medium;width:300px;height:auto;vertical-align:middle">
    <center>
    Processing..
    <br />
    <img src="../Images/Process.gif" height="100px" width="100px" />
    </center>
    </div> 
    <cc1:AlwaysVisibleControlExtender ID="AlwaysVisibleControlExtender1" TargetControlID="Progess" HorizontalSide="Center" VerticalSide="Middle" runat="server" ></cc1:AlwaysVisibleControlExtender> 
    </ProgressTemplate>
    
    </asp:UpdateProgress>
    </center>
    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

