<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmPaymentTypeMaster.aspx.cs" Inherits="Admin_frmPaymentTypeMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
       
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataKeyNames="PaymentTypeId" 
        DataSourceID="SqlDataSource1" EmptyDataText="NO Data Items" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
          <%--  <asp:BoundField DataField="PaymentTypeId" HeaderText="PaymentTypeId" 
                ReadOnly="True" SortExpression="PaymentTypeId" InsertVisible="False" />--%>
            <asp:BoundField DataField="PaymentTypeName" HeaderText="PaymentTypeName" 
                SortExpression="PaymentTypeName" />
            <asp:BoundField DataField="PaymentTypeAbbr" HeaderText="PaymentTypeAbbr" 
                SortExpression="PaymentTypeAbbr" />
            <asp:BoundField DataField="PaymentTypeDescription" 
                HeaderText="PaymentTypeDescription" 
                SortExpression="PaymentTypeDescription" />
        </Columns>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
        AutoGenerateRows="False" DataKeyNames="PaymentTypeId" 
        DataSourceID="SqlDataSource1" DefaultMode="Insert">
        <Fields>
            <asp:BoundField DataField="PaymentTypeId" HeaderText="PaymentTypeId" 
                ReadOnly="True" SortExpression="PaymentTypeId" InsertVisible="False" />
            <asp:BoundField DataField="PaymentTypeName" HeaderText="PaymentTypeName" 
                SortExpression="PaymentTypeName" />
            <asp:BoundField DataField="PaymentTypeAbbr" HeaderText="PaymentTypeAbbr" 
                SortExpression="PaymentTypeAbbr" />
            <asp:BoundField DataField="PaymentTypeDescription" 
                HeaderText="PaymentTypeDescription" 
                SortExpression="PaymentTypeDescription" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BackToMyVillageConnectionString %>" 
        DeleteCommand="DELETE FROM [tbl_PaymentTypeMaster] WHERE [PaymentTypeId] = @PaymentTypeId" 
        InsertCommand="INSERT INTO [tbl_PaymentTypeMaster] ([PaymentTypeName], [PaymentTypeAbbr], [PaymentTypeDescription]) VALUES (@PaymentTypeName, @PaymentTypeAbbr, @PaymentTypeDescription)" 
        SelectCommand="SELECT * FROM [tbl_PaymentTypeMaster]" 
        UpdateCommand="UPDATE [tbl_PaymentTypeMaster] SET [PaymentTypeName] = @PaymentTypeName, [PaymentTypeAbbr] = @PaymentTypeAbbr, [PaymentTypeDescription] = @PaymentTypeDescription WHERE [PaymentTypeId] = @PaymentTypeId">
        <DeleteParameters>
            <asp:Parameter Name="PaymentTypeId" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="PaymentTypeName" Type="String" />
            <asp:Parameter Name="PaymentTypeAbbr" Type="String" />
            <asp:Parameter Name="PaymentTypeDescription" Type="String" />
            <asp:Parameter Name="PaymentTypeId" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="PaymentTypeName" Type="String" />
            <asp:Parameter Name="PaymentTypeAbbr" Type="String" />
            <asp:Parameter Name="PaymentTypeDescription" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
</asp:Content>

