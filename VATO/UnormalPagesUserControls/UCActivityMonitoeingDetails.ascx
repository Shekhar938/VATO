<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCActivityMonitoeingDetails.ascx.cs" Inherits="UnormalPagesUserControls_UCActivityMonitoeingDetails" %>
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
                    <asp:Image ID="Image1" runat="server" Height="50px" Width="50px" 
                        ImageUrl="~/Images/NoImage.jpg" />
                </td>
            </tr>
        </table>
    </ContentTemplate>
</asp:UpdatePanel>
