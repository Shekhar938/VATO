<%@ Page Language="C#" MasterPageFile="~/Members/MembersMasterPage.master"  AutoEventWireup="true" CodeFile="frmVillageDonationDetails.aspx.cs" Inherits="frmVillageDonationDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css" >
.tableData
{text-align:left;vertical-align:bottom;font-weight:bold;font-family:Verdana;font-size:9px;	}
.tableHeading
{	text-align:center;vertical-align:bottom;font-weight:bold;font-family:Verdana;font-size:16px;}
.style2
{   height: 25px;      }
.style5
{text-align:left;vertical-align:bottom;font-weight:bold;font-family:Verdana;font-size:9px;vertical-align:top;                
            width: 173px;height: 20px; color: White ;  }
.style6
{text-align: center;vertical-align: bottom;font-family: Verdana;font-size: 16px;color: #CE0063;        }
    .style7
    {
        text-align: left;
        vertical-align: bottom;
        font-weight: bold;
        font-family: Verdana;
        font-size: 9px;
        vertical-align: top;
        width: 173px;
        height: 26px;
        color: White;
    }
    .style8
    {
        height: 26px;
    }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    
    
    <center>
        
      
    <table bgcolor="#089663" style="width: 432px">
         <tr>
        <td colspan="3" class="style6">Village Donation Details </td>
        
        </tr>
         <tr>
        <td colspan="3" class="tableHeading">&nbsp;</td>
        
        </tr>
         <tr>
        <td colspan="3" class="tableHeading">&nbsp;</td>
        
        </tr>
        <tr>
             <td class="style5">
             Donation ID
             </td>
        <td>
        <asp:DropDownList ID="ddlDonationID" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ddlDonationID_SelectedIndexChanged" Height="16px" 
                Width="125px"></asp:DropDownList>
        </td>
   <td></td>
        </tr>
        <tr>
        <td class="style5">
        Activity Name
        
        </td>
        <td>
        <asp:TextBox ID="TxtActivityId" runat="server" ReadOnly="true"></asp:TextBox>
        </td>
        <td></td>
        </tr>
        <tr>
        <td class="style5">
       Village Name
        
        </td>
        <td>
           <asp:TextBox ID="TxtVillageId" runat="server" ReadOnly="true"></asp:TextBox>
        </td><td></td>
        </tr>
          <tr>
                            <td class="style7">
                               Donation Amount Expected
                            </td>
                            <td class="style8">
                            <asp:TextBox ID="TxtDonationAmountExpected" ReadOnly="true" runat="server"></asp:TextBox></td>
                            <td class="style8">
                           
                            
                           
                </td>
            </tr>
           <tr>
                            <td class="style5">
                               Donation Amount Collected till Now
                            </td>
                            <td class="style2">
                            <asp:TextBox ID="TxtAmountCollectedtillNow" ReadOnly="true" runat="server"></asp:TextBox></td>
                            <td class="style2">
                        
                            
                           
                </td>
            </tr>
             <tr>
                            <td class="style5">
                               Donation  Minimum Amount Accepted                            </td>
                            <td>
                            <asp:TextBox ID="TxtMinimumAmountAccepted" ReadOnly="true" runat="server"></asp:TextBox></td><td>
                          
                            
                           
                </td>
            </tr>  
        <tr>
                            <td class="style5">
                               Amount Donated
                            </td>
                            <td >
                            <asp:TextBox ID="TxtAmountDonated" runat="server"></asp:TextBox></td>
                            <td style="text-align: left">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                                    ControlToValidate="TxtAmountDonated"  ErrorMessage="*" runat="server" 
                                    ForeColor="White"></asp:RequiredFieldValidator>
                           
                </td>
            </tr>
         <tr>
                            <td class="style5">
                                Remarks For Donation
                            </td>
                            <td class="tableData">
                            <asp:TextBox ID="TxtremarksForDonation" runat="server" Height="85px" 
                                    TextMode="MultiLine" Width="131px"></asp:TextBox></td><td valign="top" align="left" >
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
                                    ControlToValidate="TxtremarksForDonation"  ErrorMessage="*" runat="server" 
                                    ForeColor="White"></asp:RequiredFieldValidator>
                            
                           
                </td>
            </tr>
     
         <tr>
        <td class="style5">
   PaymentType ID
        
        </td>
        <td>
        <asp:DropDownList ID="ddlPaymenttypeid" runat="server" Height="18px" Width="125px"></asp:DropDownList>
        </td><td></td>
        </tr>
          <tr>
        <td class="style5">
            Introduced Volunteer 
        
        </td>
        <td>
        <asp:DropDownList ID="ddlIntroducedVolunteerid" runat="server" Height="16px" 
                Width="126px"></asp:DropDownList>
        </td><td></td>
        </tr>
          <tr>
        <td colspan="3" class="tableHeading">
       
        </td>
        
        </tr>
        <tr>
        <td colspan="3">
        
        <center>
        <asp:Button ID="btnAdd" runat="server" Text="Submit" style="font-weight: 700" 
                onclick="btnAdd_Click" />
     
        
               &nbsp;&nbsp;
     
        
               <asp:Button ID="btncancel" runat="server" Text="Cancel" 
                style="font-weight: 700" onclick="btncancel_Click" 
                CausesValidation="False" /></center>
        </td>
        </tr>
    </table> 
    <br />
     <asp:Label ID="lblError" runat="server"></asp:Label>
</center>
</ContentTemplate>
    </asp:UpdatePanel> 
</asp:Content>

