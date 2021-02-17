<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmVillageMaster.aspx.cs" Inherits="Admin_frmVillageMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
Manage Villages
<br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataKeyNames="VillageId" 
        DataSourceID="ObjectDataSource1" EmptyDataText="No Data Items" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="VillageId" Visible="false" HeaderText="VillageId" 
                InsertVisible="False" ReadOnly="True" SortExpression="VillageId" />
            <asp:BoundField DataField="VillageName" HeaderText="Name" 
                SortExpression="VillageName" />
            <asp:BoundField DataField="VillageAbbr" HeaderText="Abbreviation" 
                SortExpression="VillageAbbr" />
            <asp:BoundField DataField="VillageArea" HeaderText="Area" 
                SortExpression="VillageArea" />
        </Columns>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetVillageMasterData" 
        TypeName="DataSet1TableAdapters.tbl_VillageMasterTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_VillageId" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="VillageName" Type="String" />
            <asp:Parameter Name="VillageAbbr" Type="String" />
            <asp:Parameter Name="VillageArea" Type="String" />
            <asp:Parameter Name="Original_VillageId" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="VillageName" Type="String" />
            <asp:Parameter Name="VillageAbbr" Type="String" />
            <asp:Parameter Name="VillageArea" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
    <br />
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
        AutoGenerateRows="False" DataKeyNames="VillageId" 
        DataSourceID="ObjectDataSource1" DefaultMode="Insert" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
        <RowStyle BackColor="#E3EAEB" />
        <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <Fields>
            <asp:BoundField DataField="VillageId" HeaderText="VillageId" 
                InsertVisible="False" ReadOnly="True" SortExpression="VillageId" />
                
            <asp:BoundField DataField="VillageName" HeaderText="VillageName" 
                SortExpression="VillageName" />
                 <asp:BoundField DataField="VillageAbbr" HeaderText="VillageAbbr" 
                SortExpression="VillageAbbr" />
            <asp:BoundField DataField="VillageArea" HeaderText="VillageArea" 
                SortExpression="VillageArea" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:DetailsView>
    <br />
</asp:Content>

