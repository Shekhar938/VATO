<%@ Page Language="C#" MasterPageFile="~/Members/MembersMasterPage.master" AutoEventWireup="true" CodeFile="frmMemDonationDetails.aspx.cs" Inherits="Members_frmMemDonationDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
        <br />
        <br />
        <br />
        <br />
        <div id="divContent">
            <span class="style5">Your Donations Details<br />
            </span>
            &nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True"
                 
                PageSize="5"  
                DataSourceID="SqlDataSource1">
               
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:BackToMyVillageConnectionString %>" 
                SelectCommand="sp_GetMembersVillageDonationsbymemId" 
                SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="MemberId" SessionField="MemberId" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            
            
        </div>
    </center>
</asp:Content>

