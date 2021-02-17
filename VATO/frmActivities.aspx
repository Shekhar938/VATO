<%@ Page Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeFile="frmActivities.aspx.cs" Inherits="frmActivities" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
<br />
<br />
<br />
<center>
    <asp:GridView ID="grdActivities" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" Width="343px">
        <Columns>
            <asp:BoundField DataField="ActivityName" HeaderText="ActivityName" 
                SortExpression="ActivityName" />
            <asp:BoundField DataField="ActivityAbbr" HeaderText="Abbreviation" 
                SortExpression="ActivityAbbr" />
            <asp:BoundField DataField="ActivityDesc" HeaderText="Description" 
                SortExpression="ActivityDesc" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BackToMyVillageConnectionString %>" 
        SelectCommand="SELECT [ActivityName], [ActivityAbbr], [ActivityDesc] FROM [tbl_ActivityMaster]">
    </asp:SqlDataSource>
    </center>
</asp:Content>

