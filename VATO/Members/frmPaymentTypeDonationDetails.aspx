<%@ Page Language="C#" MasterPageFile="~/Members/MembersMasterPage.master" AutoEventWireup="true"
    CodeFile="frmPaymentTypeDonationDetails.aspx.cs" Inherits="Admin_frmPaymentTypeDonationDetails"
    Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/UnormalPagesUserControls/UCFileUpload.ascx" TagName="FileUpload"
    TagPrefix="Uc1" %>
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
            width: 114px;
        }
        .style6
        {
            text-align: left;
            vertical-align: bottom;
            font-weight: bold;
            font-family: Verdana;
            font-size: x-small;
            height: 20px;
            color: White;
            background-color: #089663;
            width: 114px;
        }
        .style7
        {
            width: 114px;
            color: #FFFFFF;
            font-weight: bold;
            font-size: x-small;
        }
        .style8
        {
            text-align: center;
            vertical-align: bottom;
            font-weight: bold;
            font-family: Verdana;
            font-size: x-small;
        }
        .style9
        {
            font-size: x-small;
            font-family: Verdana;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:PostBackTrigger ControlID="FileUpload1" />
            <asp:AsyncPostBackTrigger ControlID="btnAdd" EventName="Click" />
        </Triggers>
        <ContentTemplate>--%>
            <center>
                <table class="tableData">
                    <tr>
                        <td colspan="3" class="tableHeading">
                            &nbsp;Enter Your Donation Details
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
                        <td class="style7">
                            Village Donation ID
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlVillageDonationID" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlVillageDonationID_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Panel ID="Readpanel" runat="server" GroupingText="ReadOnly" 
                                CssClass="style9">
                                <table>
                                    <tr>
                                        <td>
                                            Village Name
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TxtVillageName" runat="server" ReadOnly="true"></asp:TextBox>
                                        </td>
                                        <td>
                                            PayMent Type Name
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TxtPaymentTypename" ReadOnly="true" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Activity Name
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TxtActivityName" runat="server" ReadOnly="true"></asp:TextBox>
                                        </td>
                                        <td>
                                            Total Amount Donated
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TxttotalamoutDonated" ReadOnly="true" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            Bank Name
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlBankName" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;Date</td>
                        <td>
                            <asp:TextBox ID="TxtDateofchequeordd" runat="server"></asp:TextBox>
                            <cc1:CalendarExtender TargetControlID="TxtDateofchequeordd" ID="CalendarExtender1"
                                runat="server">
                            </cc1:CalendarExtender>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="TxtDateofchequeordd"
                                ErrorMessage="*" runat="server" ForeColor="White"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;Checque No
                        </td>
                        <td>
                            <asp:TextBox ID="Txtchequeno" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="Txtchequeno"
                                ErrorMessage="*" runat="server" ForeColor="White"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            &nbsp;Status
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPaymentstatus" runat="server">
                                <asp:ListItem>--Select One--</asp:ListItem>
                                <asp:ListItem>Pending</asp:ListItem>
                                <asp:ListItem>Processing</asp:ListItem>
                                <asp:ListItem>Confomied</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            Browse File
                        </td>
                        <td colspan="2">
                            <Uc1:FileUpload ID="FileUpload1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" class="style8">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            &nbsp;Amount
                        </td>
                        <td>
                            <asp:TextBox ID="Txtcheckddamout" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CompareValidator ID="comcheckddamout" ControlToValidate="Txtcheckddamout" ControlToCompare="TxttotalamoutDonated"
                                runat="server" ErrorMessage="Enter current Amount" Type="Currency" ForeColor="White"></asp:CompareValidator>
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
                                <asp:Button ID="btncancel" runat="server" Text="Cancel" Style="font-weight: 700"
                                    OnClick="btncancel_Click" /></center>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </center>
        <%--</ContentTemplate>
    </asp:UpdatePanel>--%>
</asp:Content>
