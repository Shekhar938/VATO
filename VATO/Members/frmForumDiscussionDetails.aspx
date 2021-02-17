<%@ Page Language="C#" MasterPageFile="~/Members/MembersMasterPage.master" AutoEventWireup="true" CodeFile="frmForumDiscussionDetails.aspx.cs" Inherits="Members_ForumDiscussionDetails" Title="Untitled Page" %>

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
            font-size: xx-small;
        }
        .Question
        {
        	Color:Red;
        	
        	}
        	
        	.Answer
        {
        	Color:Blue;
        	
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
        <h1 class="style5">
            Discussion Forum</h1>
        <table width="100%" class="tabledata">
            <tr>
                <td>
                    <asp:GridView ID="GridView1" Width="100%" runat="server" AutoGenerateColumns="False"
                        OnRowCommand="GridView1_RowCommand" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" AllowPaging="True" 
                        onpageindexchanging="GridView1_PageIndexChanging" ShowFooter="True" 
                        PageSize="1">
                        <PagerSettings FirstPageText="First" LastPageText="Last" NextPageText="Next" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#E3EAEB" />
                        <Columns>
                            <asp:TemplateField ControlStyle-Width="100%">
                                <HeaderTemplate>
                                    <center>
                                        <h3>
                                            Questions
                                        </h3>
                                    </center>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <table class="tabledata" Width="100%">
                                        <tr>
                                            <td class="Question">
                                                <asp:Panel ID="panel1" runat="server" ScrollBars="Auto" Height="20px" Width="100%">
                                                    Question:
                                                    <%#Eval("DisscussionTopicPorted")%>
                                                    <asp:Label  ID="lblQuestion" runat="server" Visible="false" Text='<%#Eval("DiscussionId") %>'></asp:Label>
                                                </asp:Panel>
                                            </td>
                                            <td>
                                                MemberName:
                                                <%#Eval("FirstName")%>
                                            </td>
                                            <td >
                                                Date :
                                                <%#Eval("DiscussionDateOpen")%>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td width="100%" colspan="3">
                                                <asp:GridView ID="GridView2" EmptyDataText="NoData" Width="100%" runat="server" AutoGenerateColumns="false">
                                                    <Columns>
                                                        <asp:TemplateField>
                                                        <HeaderTemplate>
                                                        <center>
                                                        <h5>Answers For Above Question</h5>
                                                        </center>
                                                        </HeaderTemplate>
                                                            <ItemTemplate>
                                                                <table width="100%">
                                                                    <tr>
                                                                        <td colspan="2" width="100%" class="Answer">
                                                                            <asp:Panel ID="panel2" runat="server" ScrollBars="Auto" Height="20px" Width="100%">
                                                                                Answer :
                                                                                <%#Eval("ResponseData")%></asp:Panel>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td width="50%">
                                                                            Member Name:&nbsp;:&nbsp;
                                                                            <%#Eval("FirstName")%>
                                                                        </td>
                                                                        <td width="50%">
                                                                            Date&nbsp;:&nbsp;
                                                                            <%#Eval("DiscussionForumResponseDate")%>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: right" colspan="3">
                                                <asp:LinkButton ID="LinkButton1" CommandName="ClickNextpage" Text="Click Here To Submit The Answer For This Question" CommandArgument='<%#Eval("discussionid") %>'
                                                    runat="server"></asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>

<ControlStyle Width="100%"></ControlStyle>
<FooterTemplate>
<asp:LinkButton ID="linkdiscussionmaster" runat="server" ForeColor="White" PostBackUrl="~/Members/frmMemberDiscussionforumMaster.aspx">Post a Question</asp:LinkButton>
</FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Label ID="lblError" CssClass="lbldata" runat="server"></asp:Label>
    </center>
</asp:Content>

