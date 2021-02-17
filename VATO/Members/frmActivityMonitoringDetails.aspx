<%@ Page Language="C#" MasterPageFile="~/Members/MembersMasterPage.master" AutoEventWireup="true"
    CodeFile="frmActivityMonitoringDetails.aspx.cs" Inherits="Members_frmActivityMonitoringDetails"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <center>
        <br />
        <br />
        <br />
        <br />
        <div id="divContent">
            <span class="style5">Activity Monitoring Details By Volunteer</span>
            <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" AllowPaging="True"
                DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" 
                PageSize="5" onselectedindexchanged="GridView1_SelectedIndexChanged" 
                CellPadding="4" ForeColor="#333333" GridLines="None">
                <RowStyle BackColor="#E3EAEB" />
                <Columns>
                    <asp:BoundField DataField="ActivityMonitorId" Visible="false" HeaderText="ActivityMonitorId"
                        ReadOnly="True" SortExpression="ActivityMonitorId" />
                    <asp:BoundField DataField="Date" HeaderText="Date" ReadOnly="True" SortExpression="Date" />
                    <asp:BoundField DataField="Activity" HeaderText="Activity" ReadOnly="True" SortExpression="Activity" />
                    <asp:BoundField DataField="Village" HeaderText="Village" ReadOnly="True" SortExpression="Village" />
                    <asp:BoundField DataField="Volunteer Name" HeaderText="Volunteer Name" SortExpression="Volunteer Name" />
                    <asp:BoundField DataField="CompletedPercentage" HeaderText="CompletedPercentage"
                        ReadOnly="True" SortExpression="CompletedPercentage" />
                    <asp:BoundField DataField="Details" HeaderText="Details" ReadOnly="True" SortExpression="Details" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" CommandName="Details" CommandArgument='<%#Eval("ActivityMonitorId")%>'
                                runat="server">Details</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" Width="200px" Height="200px" TextMode="MultiLine" Text='<%#Eval("ActivityImagefileDescription")%>' runat="server"></asp:TextBox>
                            
                        
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                            <asp:Image Width="200px" Height="200px" ID="Image1" ImageUrl='<%#Eval("ActivityImagefileName")%>'
                                runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                     <%--<asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                          <object id="Videoplayer" classid="clsid:6BF52A52-394A-11D3-B153-00C04F79FAA6" height="170"
                                                        width="300">
                                                        <param name="URL" value='<%# Eval("ActivityImageVideofileName")%>'>
                                                        <param name="autoStart" value="True">
                                                        <param name="rate" value="1">
                                                        <param name="balance" value="0">
                                                        <param name="enabled" value="true">
                                                        <param name="enabledContextMenu" value="true">
                                                        <param name="fullScreen" value="false">
                                                        <param name="playCount" value="1">
                                                        <param name="volume" value="100">
                                                    </object>
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BackToMyVillageConnectionString %>"
                SelectCommand="getActivityCompletionDetails" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:SessionParameter Name="MemberId" SessionField="MemberId" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </center>
</asp:Content>
