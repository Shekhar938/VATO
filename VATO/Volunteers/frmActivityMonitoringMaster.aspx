<%@ Page Language="C#" MasterPageFile="~/Volunteers/VolunteerMasterPage.master" AutoEventWireup="true"
    CodeFile="frmActivityMonitoringMaster.aspx.cs" Inherits="Volunteers_frmActivityMonitoringMaster"
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
        }
        .tableHeading
        {
            text-align: center;
            vertical-align: bottom;
            font-weight: bold;
            font-family: Verdana;
            font-size: 16px;
        }
        .style5
        {
            width: 218px;
            text-align: right;
        }
        .style1
        {
            text-align: left;
        }
        .style6
        {
            text-align: center;
            vertical-align: bottom;
            font-weight: bold;
            font-family: Verdana;
            font-size: 16px;
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <center>
        <table bgcolor="#21926B" style="width: 517px">
            <tr>
                <td colspan="3" class="tableHeading">
                    Activity Monitoring Data
                </td>
            </tr>
            <tr>
                <td colspan="3" class="tableHeading">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="3" class="tableHeading">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Village Name
                </td>
                <td style="text-align: left">
                    <asp:DropDownList ID="ddlVillagename" runat="server" Height="16px" Width="190px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Activity Name
                </td>
                <td class="style1">
                    <asp:DropDownList ID="ddlAcitivityName" runat="server" Height="16px" Width="190px">
                    </asp:DropDownList>
                </td>
                <td style="text-align: left">
                    &nbsp;
                </td>
            </tr>
            
            <tr>
                <td class="style5">
                    &nbsp;Completion Percentage
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="TxtActivityCompletionPercentage" runat="server" Width="190px"></asp:TextBox>
                    (%)</td>
                <td>
                    &nbsp;<asp:RequiredFieldValidator 
                        ControlToValidate="TxtActivityCompletionPercentage" 
                        ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="White"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="*" ControlToValidate="TxtActivityCompletionPercentage"
                        Type="Integer" MinimumValue="0" MaximumValue="100" ForeColor="White"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td valign="top" class="style5" style="text-align: right">
                    Details
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="TxtDetails" runat="server" Height="102px" TextMode="MultiLine" Width="258px"></asp:TextBox>
                </td>
                <td valign="top" align="left">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtDetails"
                        ErrorMessage="*" runat="server" Font-Bold="True" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="3" class="style6">
                    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                        PostBackUrl="~/Volunteers/frmActivityMonitoeingDetails.aspx">Click Here To 
                    Attach Files</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td colspan="3" class="tableHeading">
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <center>
                        <asp:Button ID="btnAdd" runat="server" Text="Submit" Style="font-weight: 700" OnClick="btnAdd_Click" />
                        &nbsp;&nbsp;
                        <asp:Button ID="btncancel" runat="server" Text="Cancel" Style="font-weight: 700"
                            OnClick="btncancel_Click" CausesValidation="False" /></center>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </center>
</asp:Content>
