<%@ Page Language="C#" MasterPageFile="~/Reports/ReportsMasterPage.master" AutoEventWireup="true" CodeFile="frmreportsVillageMaster.aspx.cs" Inherits="Reports_frmreportsVillageDonationMaster" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css" >
.tableData
{
	text-align:left;
	vertical-align:bottom;
	font-weight:bold;
	font-family:Verdana;
	font-size:9px;
	}
.tableHeading
{
	text-align:center;
	vertical-align:bottom;
	font-weight:bold;
	background-color:Aqua;
	font-family:Verdana;
	font-size:25px;
	
	}
.GridHeaderalign
{
	text-align:left ;
	font-weight:bold;
	font-size:16px;
	}
.GridItemalign
{
	text-align:left ;
	font-size:12px;
	}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<table>
<tr>
<td class="tableHeading">
We Are Conducting Activities In there village
</td>
</tr>
<tr>
<td>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="VillageName" HeaderText="Village Name" HeaderStyle-CssClass="GridHeaderalign" ItemStyle-CssClass="GridItemalign"
                SortExpression="VillageName" />
            <asp:BoundField DataField="VillageArea" HeaderText="Village Area" HeaderStyle-CssClass="GridHeaderalign" ItemStyle-CssClass="GridItemalign"
                SortExpression="VillageArea" />
            <asp:BoundField DataField="VillagePopulation" HeaderText="Village Population" HeaderStyle-CssClass="GridHeaderalign" ItemStyle-CssClass="GridItemalign"
                SortExpression="VillagePopulation" />
            <asp:BoundField DataField="VillageEducationPercentage" HeaderStyle-CssClass="GridHeaderalign" ItemStyle-CssClass="GridItemalign"
                HeaderText="Education Percentage" 
                SortExpression="VillageEducationPercentage" />
        </Columns>
    </asp:GridView>
</td>
</tr>
<tr>
<td>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetReportsVillageMasterData" 
        TypeName="DataSet1TableAdapters.tbl_VillageMaster1TableAdapter">
        <InsertParameters>
            <asp:Parameter Name="VillageName" Type="String" />
            <asp:Parameter Name="VillageArea" Type="String" />
            <asp:Parameter Name="VillagePopulation" Type="Int64" />
            <asp:Parameter Name="VillageEducationPercentage" Type="Int32" />
        </InsertParameters>
    </asp:ObjectDataSource>
</td>
</tr>
</table>
</center>
</asp:Content>

