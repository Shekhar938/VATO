<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="frmVolunteersMaster.aspx.cs" Inherits="Admin_frmVolunteersMaster" Title="Untitled Page" %>

<%@ Register Src="~/UnormalPagesUserControls/UCFileUpload.ascx" TagName="FileUpload"
    TagPrefix="Uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .tableData
        {
            text-align: justify;
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
            text-align: justify;
            vertical-align: top;
            font-weight: bold;
            font-family: Verdana;
            font-size: smaller;
            width: 184px;
            height: 20px;
            color: White;
            background-color: #089663;
        }
        .style6
        {
            text-align: left;
            vertical-align: bottom;
            font-weight: bold;
            font-family: Verdana;
            font-size: xx-small;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <center>
        <table bgcolor="#089663" style="width: 514px">
            <tr>
                <td colspan="3" class="tableHeading">
                    Register Volunteers Profile
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
                    &nbsp;Name
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="TxtVolunteerName" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="TxtVolunteerName"
                        ErrorMessage="*" runat="server" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;Date Of Birth
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="TxtVolunteerDateofbirth" runat="server" Height="21px" Width="200px"></asp:TextBox>
                    <cc1:CalendarExtender ID="CalendarExtender" TargetControlID="TxtVolunteerDateofbirth"
                        runat="server">
                    </cc1:CalendarExtender>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TxtVolunteerDateofbirth"
                        ErrorMessage="*" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td class="style5" valign="top">
                    Image
                </td>
                <td colspan="2">
                    <Uc1:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Description
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="TxtVolunteerDescription" runat="server" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TxtVolunteerDescription"
                        ErrorMessage="*" runat="server" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;Mobile
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="TxtMobileNo" runat="server" Width="200px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="TxtMobileNo"
                        ErrorMessage="*" runat="server" ForeColor="White"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ErrorMessage="Enter Numerics Only" ForeColor="White" 
                        MaximumValue="9999999999" MinimumValue="0" Type="Currency" 
                        ControlToValidate="TxtMobileNo"></asp:RangeValidator> 
                </td>
                <td>
                  
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Address
                </td>
                <td style="text-align: left">
                    <asp:TextBox TextMode="MultiLine" ID="TxtvolunteerAddress" runat="server" Width="200px"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="TxtvolunteerAddress"
                        ErrorMessage="*" runat="server" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td>
                  
                </td>
            </tr>
            <tr>
                <td class="style5">
                    User Name
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtUserName" runat="server" Width="200px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtUserName"
                        ErrorMessage="*" runat="server" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td>
                   
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Pass Word
                </td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtPassword"
                        ErrorMessage="*" runat="server" ForeColor="White"></asp:RequiredFieldValidator>
              
                </td>
                <td>
                   
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;
                </td>
                <td style="text-align: left">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="3" class="style6">
                    (* are mandetory)
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
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btncancel" runat="server" Text="Cancel" Style="font-weight: 700"
                            OnClick="btncancel_Click" CausesValidation="False" /></center>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </center>
</asp:Content>
