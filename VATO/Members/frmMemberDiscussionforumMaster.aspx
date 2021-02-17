<%@ Page Language="C#" MasterPageFile="~/Members/MembersMasterPage.master" AutoEventWireup="true" CodeFile="frmMemberDiscussionforumMaster.aspx.cs" Inherits="Members_frmMemberDiscussionforumMaster" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .style1
        {
            font-size: large;
        }
        .tableData
        {
            text-align: left;
            font-weight: bold;
            font-size: x-large;
        }
        .style5
        {
            text-align: left;
            font-weight: bold;
            font-size: smaller;
            width: 132px;
            height: 20px;
            color: White;
            background-color: #089663;
        }
        .style6
        {
            width: 132px;
        }
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <center>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            
            <center style="height: auto">
            <asp:Panel ID="mainPanel" runat="server">
                <br />
                <span class="style1">Member Discussion Forum<br />
                </span>
                <br />
                <table class="tableData" style="border: 2px solid #003000; width: 345px; height: 185px;"
                    cellpadding="1" cellspacing="1">
                    <tr>
                        <td class="style5" valign="top">
                            Discussion Date Closerd</td>
                        <td class="tableData">
                            <asp:TextBox ID="txtDiscussionClosedate" runat="server" Width="200px"></asp:TextBox>
                            
                            <cc1:CalendarExtender ID="txtDiscussionClosedate_CalendarExtender" 
                                runat="server" Enabled="True" TargetControlID="txtDiscussionClosedate">
                            </cc1:CalendarExtender>
                            
                        </td>
                        <td> 
                            <asp:RequiredFieldValidator ControlToValidate="txtDiscussionClosedate" 
                                ID="RequiredFieldValidator3" runat="server" 
                                ErrorMessage="*" Font-Bold="True" ForeColor="White"></asp:RequiredFieldValidator>
                            </td>
                    </tr>
                    <tr>
                        <td class="style5" valign="top">
                            </td>
                        <td class="tableData">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                   
                    <tr>
                        <td class="style5" valign="top">
                            Give Your Description</td>
                        <td class="tableData" valign="top">
                            <asp:TextBox ID="txtDiscussiontopic" runat="server" Height="71px" TextMode="MultiLine" 
                                Width="200px"></asp:TextBox>
                        </td>
                        <td valign="top">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtDiscussiontopic" ErrorMessage="*" ForeColor="White"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            &nbsp;&nbsp;&nbsp; * are mandatory
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" style="text-align: right">
                            <asp:Button ID="btnSubmit" runat="server" Height="26px" 
                                OnClick="btnSubmit_Click" Text="Submit" Width="69px" />
                        </td>
                        <td style="text-align: right">
                            <asp:Button ID="btnClear" runat="server" CausesValidation="false" Height="25px" 
                                OnClick="btnClear_Click" Text="Clear" Width="70px" />
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
                <br />
               
                <br />
                <asp:Label ID="lblMsg" runat="server" ForeColor="#FF3000"></asp:Label>
                </asp:Panel>
            </center>
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
            </ContentTemplate>
        </asp:UpdatePanel>
    </center>
</asp:Content>

