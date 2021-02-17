<%@ Page Language="C#" MasterPageFile="~/Volunteers/VolunteerMasterPage.master" AutoEventWireup="true" CodeFile="frmforumAnswers.aspx.cs" Inherits="Members_frmforumAnswers" Title="Untitled Page" %>
 <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .tabledata
        {
            font-family: Verdana;
            font-weight: bold;
            font-size: xx-small;
            text-align: left;
        }
        .lbldata
        {
        	font-weight: bold; 
        	
        	font-family: Verdana;
          color: #FF0066;
        font-size: x-small;
    }
      .head
    {
        color: #663300;
    }
    .style5
    {
        font-size: large;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<center>
<h1 class="head">
    <span class="style5">Post Your Forum Answer</span>
</h1>
<asp:UpdatePanel ID="panel" runat="server">
<Triggers>
<asp:AsyncPostBackTrigger ControlID="btnAdd" EventName="Click" />
<asp:AsyncPostBackTrigger ControlID="btnBack" EventName="Click" />

</Triggers>
<ContentTemplate>

<asp:Panel ID="mainpanel" runat="server">
<table class="tabledata">
<tr>
<td>QuestionName </td>
<td>
<asp:Label ID="lblQuestion" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td>
AnsWers Text
</td></tr><tr>
<td colspan="2">
<asp:TextBox ID="txtAnswertext" TextMode="MultiLine" runat="server" Height="71px" 
        Width="346px"></asp:TextBox>
</td>
<td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtAnswertext"></asp:RequiredFieldValidator>
</td>
</tr>

<tr>
<td colspan="3">
<center>
<asp:Button ID="btnBack" Text="Back" runat="server" onclick="btnBack_Click" 
        ValidationGroup="b1" />

<asp:Button ID="btnAdd" Text="Submit" runat="server" onclick="btnAdd_Click" />
</center>
</td>
</tr>
</table>
</asp:Panel>
<br />
<br />
                <center>
               <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        <div id="Progress" runat="server" style="background-color: Gray; font-weight: bold; font-family: Verdana; font-size: medium;width:300px;height:auto;vertical-align:middle">
                        <center>
                            Processing......<br />
                            <img src="../Images/Process.gif" height="100px" width="100px" />
                        </center>
                        </div>
                        <cc1:AlwaysVisibleControlExtender TargetControlID="Progress"  HorizontalSide="Center" VerticalSide="Middle" ID="AlwaysVisibleControlExtender1" runat="server">
                        </cc1:AlwaysVisibleControlExtender>
                    </ProgressTemplate>
                </asp:UpdateProgress>

                </center>
                <br />
<br />
<asp:Label ID="lblError" CssClass="lbldata" runat="server"></asp:Label>
</ContentTemplate>
</asp:UpdatePanel>

</center>

</asp:Content>

