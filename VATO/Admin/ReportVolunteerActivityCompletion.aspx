﻿<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ReportVolunteerActivityCompletion.aspx.cs" Inherits="Admin_ReportVolunteerActivityCompletion" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            font-family: Verdana;
        }
    </style>
    <script language="javascript" type="text/javascript">
 
    function callPrint(elementId)
    {
       var prtContent = document.getElementById(elementId);                
       var WinPrint = window.open('','', 'left=0,top=0,width=1000,height=600,toolbar=2,scrollbars=2,status=0');
       var docColor="Black";
       var strInnerHTML=prtContent.innerHTML;
       var strModifiedInnerHTMl=strInnerHTML.replace(/white/g,docColor);
       WinPrint.document.write(strModifiedInnerHTMl);
       WinPrint.document.close();
       WinPrint.focus();
       WinPrint.print();
       WinPrint.close();
    }
    
    
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <br />
    <br />
        <asp:Button OnClientClick="callPrint('divContent')" ID="Button1" runat="server" Text="Get Print" />
    <br />
    <br />
    <div id="divContent">
        <span class="style5">Report For Activity Completion Details<br />
        </span>&nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="true" DataSourceID="SqlDataSource1">
        <Columns>
           
        </Columns>
    </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BackToMyVillageConnectionString %>" 
            SelectCommand="spGetVolunteerActivityCompletionReport" SelectCommandType="StoredProcedure">
        </asp:SqlDataSource>
    </div>
    </center></asp:Content>

