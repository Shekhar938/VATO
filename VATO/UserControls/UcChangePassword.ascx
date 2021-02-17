<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UcChangePassword.ascx.cs"
    Inherits="UserControls_UcChangePassword" %>
<style type="text/css">
           
    .style2
    {
        width: 146px;
    }
           
    .style3
    {
        color: #00659C;
    }
    .style4
    {
        width: 146px;
        color: #00659C;
    }
           
    .style5
    {
        font-size: xx-small;
    }
    .style6
    {
        width: 146px;
        color: #00659C;
        font-size: xx-small;
    }
           
</style>
<center style="border: thin solid #00659C; width: 362px; height: 299px;">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <Triggers >
    <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
    </Triggers>
    <ContentTemplate >
    <table >
        <tr>
            <td colspan="3" >
                <b><span >Change Your Password</span> </b>
            </td>
        </tr>
        <tr>
            <td colspan="3"><br />
                </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                Old Password
            </td>
            <td>
                <asp:TextBox ID="txtOldPwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtOldPwd" ErrorMessage="*" ForeColor="White"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td   >
                New Password
            </td>
            <td >
                <asp:TextBox ID="txtNewPwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtNewPwd" ID="RequiredFieldValidator2"
                    runat="server" ErrorMessage="*" ForeColor="White"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4" >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td  >
               Confirm Password
            </td>
            <td >
                <asp:TextBox ID="txtConPwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtConPwd" ID="RequiredFieldValidator3"
                    runat="server" ErrorMessage="*" ForeColor="White"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" ControlToValidate="txtConPwd" ControlToCompare="txtNewPwd"
                    runat="server" ErrorMessage="Not Matched" ForeColor="White"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style2" >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" >
                &nbsp;</td>
            <td style="text-align: right" >
                <asp:Button ID="Button1" runat="server" Height="26px" Text="Submit" 
                    Width="88px" onclick="Button1_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <asp:Label ID="lblMsg" runat="server" style="font-weight: 700" ></asp:Label>
    
    </ContentTemplate>
    </asp:UpdatePanel>
</center>
