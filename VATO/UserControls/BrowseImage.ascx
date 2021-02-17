<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BrowseImage.ascx.cs" Inherits="BrowseImage" %>
<style type="text/css">
    .style4
    {
        width: 200px;
        text-align:justify;
        font-size: 9px;
        font-family: Verdana;
    }
</style>
<asp:UpdatePanel ID="biupdatepanel" runat="server" >
<Triggers >
<asp:PostBackTrigger  ControlID="btnShowImg" />
</Triggers>
<ContentTemplate>
<table style="width: 300px; height: 120px; font-family: Verdana; font-size: 10px;">
    <tr>
        <td class="style4" height="3px">
            
            <asp:FileUpload ID="Upload1" runat="server" Font-Names="Verdana" Font-Size="10px" />
          
            
        </td>
        <td rowspan="4" style="text-align: right">
            
             <asp:Image ID="imgMyPhoto" BorderStyle="Dashed" BorderWidth="1" runat="server" Height="100px"
                Width="100px" />
            
         
        </td>
    </tr>
    <tr>
        <td class="style4" height="3px">
            To Bind your Photo browse image and click the &#39;Save Photo&#39; button. Then
            only your Image will add in
           
            your account. Other wise default image will be added.
        </td>
    </tr>
    <tr>
        <td class="style4" height="3px">
           
            <asp:Button ID="btnShowImg" CausesValidation="false" runat="server" Text="Show Image"
                OnClick="btnShowImg_Click" Font-Names="Verdana" Font-Size="10px" />
           
            
        </td>
    </tr>
    <tr>
        <td class="style4">
            
            <asp:Label ID="lblMessage" runat="server" Font-Names="Verdana" Font-Size="10px" ForeColor="Red"></asp:Label>
            
            
        </td>
    </tr>
</table>
</ContentTemplate>
</asp:UpdatePanel>
