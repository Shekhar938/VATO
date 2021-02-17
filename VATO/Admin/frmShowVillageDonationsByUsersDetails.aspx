<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmShowVillageDonationsByUsersDetails.aspx.cs" Inherits="Admin_frmVillageDonationDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<center>
<br />
<br />
Donation To Villages Based On Members
<br />
<br />
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" Width="100%" ForeColor="#333333" 
        GridLines="None" Height="205px" AllowPaging="True" Font-Size="X-Small" >
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#E3EAEB" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
<br />
    <asp:Label ID="lblMsg" runat="server" ></asp:Label>
<br />

</center>


</asp:Content>

