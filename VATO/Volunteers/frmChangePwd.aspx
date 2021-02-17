<%@ Page Language="C#" MasterPageFile="~/Volunteers/VolunteerMasterPage.master" AutoEventWireup="true" CodeFile="frmChangePwd.aspx.cs" Inherits="Volunteers_frmChangePwd" Title="Untitled Page" %>

<%@ Register src="../UserControls/UcChangePassword.ascx" tagname="UcChangePassword" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
    <uc1:UcChangePassword ID="UcChangePassword1" runat="server" />
</asp:Content>

