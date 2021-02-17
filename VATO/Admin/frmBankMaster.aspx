<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="frmBankMaster.aspx.cs" Inherits="Admin_frmBankMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            DataKeyNames="BankId" DataSourceID="ObjectDataSource1" 
            EmptyDataText="No Data Items" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                <asp:BoundField DataField="BankId" HeaderText="BankId" ReadOnly="True" SortExpression="BankId"
                    InsertVisible="False" Visible="false" />
                <asp:BoundField DataField="BankName" HeaderText="Bank Name" SortExpression="BankName" />
                <asp:BoundField DataField="BankAbbr" HeaderText="Abbrevation" SortExpression="BankAbbr" />
                <asp:BoundField DataField="BankDescription" HeaderText="Description" SortExpression="BankDescription" />
            </Columns>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete"
            InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetBankData"
            TypeName="DataSet1TableAdapters.tbl_BankMasterTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_BankId" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="BankName" Type="String" />
                <asp:Parameter Name="BankAbbr" Type="String" />
                <asp:Parameter Name="BankDescription" Type="String" />
                <asp:Parameter Name="Original_BankId" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="BankName" Type="String" />
                <asp:Parameter Name="BankAbbr" Type="String" />
                <asp:Parameter Name="BankDescription" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <br />
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AutoGenerateRows="False"
            DataKeyNames="BankId" DataSourceID="ObjectDataSource1" DefaultMode="Insert">
            <Fields>
                <asp:BoundField DataField="BankId" HeaderText="BankId" ReadOnly="True" SortExpression="BankId"
                    InsertVisible="False" />
                <asp:BoundField DataField="BankName" HeaderText="Bank Name" SortExpression="BankName" />
                <asp:BoundField DataField="BankAbbr" HeaderText="Abbrevation" SortExpression="BankAbbr" />
                <asp:BoundField DataField="BankDescription" HeaderText="Description" SortExpression="BankDescription" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <br />
        <br />
        <br />
    </center>
</asp:Content>
