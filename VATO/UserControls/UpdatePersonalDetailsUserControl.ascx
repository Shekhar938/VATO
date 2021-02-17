<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UpdatePersonalDetailsUserControl.ascx.cs"
    Inherits="UpdatePersonalDetails" %>
<%@ Register Src="~/UserControls/BrowseImage.ascx" TagName="BrowseImage" TagPrefix="Uc1" %>

<script src="TextValidation.js" type="text/javascript"></script>

<style type="text/css">
    .HeaderTextStyle
    {
        font-weight: bold;
        text-align: left;
        font-size: medium;
        text-decoration: underline;
        font-family: Verdana;
        color: Blue;
    }
    .NormalTextStyle
    {
        text-align: left;
        font-size: 10px;
        font-family: Verdana;
        color: #00659C;
    }
    .style5
    {
        font-family: Verdana;
        font-size: xx-small;
        text-align: left;
    }
    .style6
    {
        color: #FF3300;
        font-family: Verdana;
        font-size: 9px;
    }
    .style7
    {
        font-weight: bold;
        text-align: left;
        font-size: medium;
        text-decoration: underline;
        font-family: Verdana;
        color: #00659C;
    }
    .style8
    {
        color: #00659C;
        font-weight: bold;
    }
    .style9
    {
        font-weight: bold;
    }
    .style11
    {
        width: 144px;
    }
    .style12
    {
        text-align: left;
        font-size: 10px;
        font-family: Verdana;
        color: #00659C;
        width: 113px;
    }
</style>
<center style="width: 534px">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="imgbtnSubmit" EventName="Click" />
            <asp:PostBackTrigger ControlID="BrowseImage1" />
        </Triggers>
        <ContentTemplate>
            <fieldset style="width: 474px; border: thin solid #00659C;">
                <table style="border-color: Maroon; border-width: medium; width: 455px; background-color:White;">
                    <tr>
                        <td align="left" colspan="5" class="style7">
                            Update Your Personal Details
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5" style="text-align: center">
                            <asp:Label ID="lblMsg" runat="server" BackColor="#FFFF99" Font-Bold="True" Font-Names="Verdana"
                                Font-Size="9px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50px">
                        </td>
                        <td class="style12">
                            <b>&nbsp;&nbsp;Email </b> <span class="style6">*</span><b> </b>
                        </td>
                        <td align="left" class="style11">
                            <asp:TextBox ID="txtEmailId" runat="server" MaxLength="30"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="rfvEmailId" runat="server" ControlToValidate="txtEmailId"
                                ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td style="text-align: right">
                            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmailId"
                                ErrorMessage="Enter Valid MailID" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50px">
                        </td>
                        <td class="style12">
                            <b>&nbsp;&nbsp;Alternate Email </b> <span class="style6">*</span><b> </b>
                        </td>
                        <td align="left" class="style11">
                            <asp:TextBox ID="txtAltMail" runat="server" MaxLength="30"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAltMail"
                                ErrorMessage="Enter Valid MailID" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50px">
                            &nbsp;
                        </td>
                        <td class="style12">
                            <b>&nbsp;&nbsp; Fax No </b> <span class="style6">*</span><b> </b>
                        </td>
                        <td align="left" class="style11">
                            <asp:TextBox ID="txtFaxNo" onKeypress="return onlyNumbershifen(event)" runat="server"
                                MaxLength="15"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtFaxNo"
                                ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50px">
                        </td>
                        <td colspan="4" align="left" class="style9">
                            <span class="style5">&nbsp;&nbsp; <span class="style8">To Add New Photo Browse Here </span> </span>
                            <b>
                            <br />
                            </b>
                            <Uc1:BrowseImage ID="BrowseImage1" runat="server" DefaultImageUrl="~/UserControls/Images/NoImage.jpg" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 50px">
                        </td>
                        <td colspan="4" align="right">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5">
                            <span class="style6">( * Mandetory)</span><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td colspan="3">
                            <br />
                        </td>
                        <td style="text-align: right">
                            <asp:ImageButton ID="imgbtnSubmit" runat="server" ImageUrl="~/UserControls/Images/btn_submit.jpg"
                                OnClick="imgbtnSubmit_Click" />
                        </td>
                    </tr>
                </table>
            </fieldset>
            <br />
            <asp:Label ID="lblError" runat="server" BackColor="#FFFF99" Font-Bold="True" Font-Names="Verdana"
                Font-Size="9px"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
</center>
