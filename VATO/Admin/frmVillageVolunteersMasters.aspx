<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="frmVillageVolunteersMasters.aspx.cs" Inherits="Admin_frmMemberQuestionAnswers"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .tableData
        {
            text-align: left;
            vertical-align: bottom;
            font-weight: bold;
            font-family: Verdana;
            font-size: 9px;
            width: 295px;
        }
        .tableHeading
        {
            text-align: center;
            vertical-align: bottom;
            font-weight: bold;
            font-family: Verdana;
            font-size: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <center>
    <asp:UpdatePanel ID="Updatepanel1" runat="server">
    <Triggers>
    <asp:AsyncPostBackTrigger ControlID="btnAdd" EventName="Click" />
    <asp:AsyncPostBackTrigger ControlID="btncancel" EventName="Click" />
        <asp:AsyncPostBackTrigger ControlID="ddlVillageId" EventName="SelectedIndexChanged" />

    </Triggers>
    <ContentTemplate>
    
        <table bgcolor="#188E63" style="width: 337px" cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td colspan="3" class="tableHeading">
                    Village Volunteer Master Data
                </td>
            </tr>
            <tr>
                <td colspan="3" class="tableHeading">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td style="text-align: left">
                    Volunteer Name
                </td>
                <td style="text-align: left">
                    <asp:DropDownList ID="ddlvolunteerID" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlvolunteerID_SelectedIndexChanged1"
                        Height="19px" Width="160px">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="ddlvolunteerID" ErrorMessage="*" 
                        InitialValue="--Select One--" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="left" valign="top">
                    Volunteer Address
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="TxtVolunteeraddress" ReadOnly="true" runat="server" Height="66px"
                        TextMode="MultiLine" Width="155px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TxtVolunteeraddress" ErrorMessage="*" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: left">
                    Village Name
                </td>
                <td style="text-align: left">
                    <asp:DropDownList ID="ddlVillageId" runat="server" AutoPostBack="True" Height="16px"
                        Width="160px">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="ddlVillageId" ErrorMessage="*" 
                        InitialValue="--Select One--" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: left">
                    Activity Name
                </td>
                <td style="text-align: left">
                    <asp:DropDownList ID="ddlActivityId" runat="server" AutoPostBack="True" Height="16px"
                        Width="160px">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="ddlActivityId" ErrorMessage="*" 
                        InitialValue="--Select One--" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="3" class="tableHeading">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <center>
                        <asp:Button ID="btnAdd" runat="server" Text="Submit" Style="font-weight: 700" OnClick="btnAdd_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btncancel" runat="server" Text="Cancel" Style="font-weight: 700"
                            OnClick="btncancel_Click" CausesValidation="False" /></center>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    </center>
</asp:Content>
