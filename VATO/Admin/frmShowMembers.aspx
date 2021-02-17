<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmShowMembers.aspx.cs" Inherits="Admin_frmShowMembers" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<br />
Registered Members Details<br />
<br />
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" Width="100%" Font-Size="X-Small" AllowPaging="True" 
        AutoGenerateColumns="False" DataSourceID="SqlDataSource1"  >
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:BoundField DataField="FirstName" HeaderText="First Name" 
                SortExpression="FirstName" />
            <asp:BoundField DataField="MiddleName" HeaderText="Middle Name" 
                SortExpression="MiddleName" />
            <asp:BoundField DataField="MailId" HeaderText="MailId" 
                SortExpression="MailId" />
            <asp:BoundField DataField="ContactNo" HeaderText="Contact No" 
                SortExpression="ContactNo" />
            <asp:BoundField DataField="Address" HeaderText="Address" 
                SortExpression="Address" />
        </Columns>
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BackToMyVillageConnectionString %>" 
        SelectCommand="SELECT [FirstName], [MiddleName], [MailId], [ContactNo], [Address] FROM [tbl_MembersMaster]">
    </asp:SqlDataSource>
<br />
    <asp:Label ID="lblMsg" runat="server" ></asp:Label>
<br />

</center>
</asp:Content>

