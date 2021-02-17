<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCActivityVideofile.ascx.cs" Inherits="UnormalPagesUserControls_UCActivityVideofile" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <Triggers>
        <asp:PostBackTrigger ControlID="btnAttachFile" />
    </Triggers>
    <ContentTemplate>
        <table>
            <tr>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>
                    <asp:Button CausesValidation="false" runat="server" ID="btnAttachFile" Text="Attach File"
                        OnClick="btnAttachFile_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </ContentTemplate>
</asp:UpdatePanel>
