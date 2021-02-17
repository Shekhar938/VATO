<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmActivityMaster.aspx.cs" Inherits="Admin_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataKeyNames="ActivityId" 
        DataSourceID="ObjectDataSource1" EmptyDataText="No Data Found To Display" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            <asp:BoundField DataField="ActivityId" Visible="false" HeaderText="ActivityId" 
                InsertVisible="False" ReadOnly="True" SortExpression="ActivityId" />
            <asp:BoundField DataField="ActivityName" HeaderText="Name" 
                SortExpression="ActivityName" />
            <asp:BoundField DataField="ActivityAbbr" HeaderText="Abbreviation" 
                SortExpression="ActivityAbbr" />
            <asp:BoundField DataField="ActivityDesc" HeaderText="Description" 
                SortExpression="ActivityDesc" />
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
        SelectMethod="GetActivityMasterData" 
        TypeName="DataSet1TableAdapters.tbl_ActivityMasterTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_ActivityId" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="ActivityName" Type="String" />
            <asp:Parameter Name="ActivityAbbr" Type="String" />
            <asp:Parameter Name="ActivityDesc" Type="String" />
            <asp:Parameter Name="Original_ActivityId" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="ActivityName" Type="String" />
            <asp:Parameter Name="ActivityAbbr" Type="String" />
            <asp:Parameter Name="ActivityDesc" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        DataKeyNames="ActivityId" DataSourceID="ObjectDataSource1" DefaultMode="Insert" 
        Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="ActivityId" HeaderText="ActivityId" 
                InsertVisible="False" ReadOnly="True" SortExpression="ActivityId" />
            <asp:BoundField DataField="ActivityName" HeaderText="Name" 
                SortExpression="ActivityName" />
            <asp:BoundField DataField="ActivityAbbr" HeaderText="Abbreviation" 
                SortExpression="ActivityAbbr" />
            <asp:BoundField DataField="ActivityDesc" HeaderText="Description" 
                SortExpression="ActivityDesc" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    </center>
</asp:Content>

