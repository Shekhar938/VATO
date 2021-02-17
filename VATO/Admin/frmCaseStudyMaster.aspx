<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmCaseStudyMaster.aspx.cs" Inherits="Admin_frmCaseStudyMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<br />
<center>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataKeyNames="CaseStudyId" 
        DataSourceID="ObjectDataSource1" EmptyDataText="No Data " Width="417px" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="CaseStudyId" Visible="false" HeaderText="CaseStudyId" 
                InsertVisible="False" ReadOnly="True" SortExpression="CaseStudyId" />
            <asp:BoundField DataField="CaseStudyType" HeaderText="Case Study Type" 
                HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" 
                SortExpression="CaseStudyType" >
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="CaseStudyAbbv" HeaderText="Abbrevation" 
                HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left"
                SortExpression="CaseStudyAbbv" >
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="CaseStudyDescription" 
                HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left"
                HeaderText="Description" SortExpression="CaseStudyDescription" >
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
            </asp:BoundField>
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
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetCasestudyMaster" 
        TypeName="DataSet1TableAdapters.tbl_CaseStudyMasterTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_CaseStudyId" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="CaseStudyType" Type="String" />
            <asp:Parameter Name="CaseStudyAbbv" Type="String" />
            <asp:Parameter Name="CaseStudyDescription" Type="String" />
            <asp:Parameter Name="Original_CaseStudyId" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="CaseStudyType" Type="String" />
            <asp:Parameter Name="CaseStudyAbbv" Type="String" />
            <asp:Parameter Name="CaseStudyDescription" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
    <br />
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" Height="49px" Width="264px" 
        AutoGenerateRows="False" DataKeyNames="CaseStudyId" 
        DataSourceID="ObjectDataSource1" DefaultMode="Insert">
        <Fields>
            <asp:BoundField DataField="CaseStudyId" HeaderText="CaseStudyId" 
                InsertVisible="False" ReadOnly="True" SortExpression="CaseStudyId" />
            <asp:BoundField DataField="CaseStudyType" HeaderText="Case Study Type" HeaderStyle-HorizontalAlign="Left" 
                SortExpression="CaseStudyType" >
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="CaseStudyAbbv" HeaderText="Abbrevation" HeaderStyle-HorizontalAlign="Left" 
                SortExpression="CaseStudyAbbv" >
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="CaseStudyDescription" HeaderStyle-HorizontalAlign="Left" 
                HeaderText="Description" SortExpression="CaseStudyDescription" >
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:BoundField>
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    <br />
    <br />
</center>
</asp:Content>

