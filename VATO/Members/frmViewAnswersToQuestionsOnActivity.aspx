<%@ Page Language="C#" MasterPageFile="~/Members/MembersMasterPage.master" AutoEventWireup="true" CodeFile="frmViewAnswersToQuestionsOnActivity.aspx.cs" Inherits="Members_frmViewAnswersToQuestionsOnActivity" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<br />
Answers Provided By Volunteer.
<br />
<br />
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" Width="90%" Font-Size="X-Small" AllowPaging="True" 
        DataSourceID="SqlDataSource1"  >
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#E3EAEB" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BackToMyVillageConnectionString %>" 
        SelectCommand="sp_GetAnswersForQueries" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:SessionParameter Name="memberId" SessionField="MemberId" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
<br />
    <asp:Label ID="lblMsg" runat="server" ></asp:Label>
<br />

</center>
</asp:Content>

