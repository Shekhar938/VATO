<%@ Page Language="C#" MasterPageFile="~/Reports/ReportsMasterPage.master" AutoEventWireup="true" CodeFile="frmReportsVillageDonationMaster.aspx.cs" Inherits="Reports_frmReportsVillagedetails" Title="Untitled Page" %>

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
<td class="tableHeading">Activities Conduct In there </td>
</tr>
<tr>
<td>
    <asp:GridView ID="GridView1" runat="server" RowStyle-CssClass="GridItemalign" PagerStyle-CssClass="GridItemalign" DataSourceID="SqlDataSource1" HeaderStyle-CssClass="GridHeaderalign" >
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:BackToMyVillageConnectionString %>" 
        SelectCommand="Sp_ReportsVillageDonationMasteDetalis" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
</td>
</tr>
<tr>
<td></td>
</tr>
</table>
</center>
</asp:Content>

