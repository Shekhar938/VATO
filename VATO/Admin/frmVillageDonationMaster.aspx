<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="frmVillageDonationMaster.aspx.cs" Inherits="Admin_frmVillageDonationMaster"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css" >
.tableData
{
	text-align:left;
	vertical-align:bottom;
	font-weight:bold;
	font-family:Verdana;
	font-size:9px;
	background:#003300;
	}
.tableHeading
{
	text-align:center;
	vertical-align:bottom;
	font-weight:bold;
	font-family:Verdana;
	font-size:16px;
	background:#003300;
	
	}


        .style5
        {
            text-align: left;
            vertical-align: bottom;
            font-weight: bold;
            font-family: Verdana;
            font-size: smaller;
            width: 138px;
            height: 20px;
            color: White;
            background-color: #003300;
        }


        .style6
        {
            text-align: left;
            vertical-align: bottom;
            font-weight: bold;
            font-family: Verdana;
            font-size: x-small;
        }
 p.MsoNormal
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:10.0pt;
	margin-left:0in;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    
    <ContentTemplate >
    
    <center>
    <br />
    <br />
    <br />
        <table style="width: 73%" class="tableData" bgcolor="#003300">
        <tr>
        <td colspan="3" class="tableHeading">Village Donation Information</td>
        
        </tr>
        
        
        <tr>
        <td colspan="3" class="tableHeading">&nbsp;</td>
        
        </tr>
        
        
        <tr>
        <td colspan="3" class="tableHeading">&nbsp;</td>
        
        </tr>
        
        

               <tr>
                <td class="style5">
                    
                                Activity Name</td>
                            <td bgcolor="#003300">
                           <asp:DropDownList ID="ddlactivityid" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="ddlactivityid_SelectedIndexChanged" Height="19px" 
                                    Width="130px">
                                </asp:DropDownList></td><td bgcolor="#003300">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                                ControlToValidate="ddlactivityid"  ErrorMessage="*" runat="server" 
                                ForeColor="White"></asp:RequiredFieldValidator>
                          
                </td>
            </tr>
            
            <tr>
                <td class="style5">
                  
                                Village Name</td>
                            <td bgcolor="#003300">
                                <asp:DropDownList ID="ddlvillageid" runat="server" AutoPostBack="True" 
                                    Height="16px" Width="130px">
                                </asp:DropDownList>
                </td><td bgcolor="#003300">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                                ControlToValidate="ddlvillageid"  ErrorMessage="*" runat="server" 
                                ForeColor="White"></asp:RequiredFieldValidator>
                                           <asp:RangeValidator ID="RagDonationamountexpeted" runat="server" 
                                ControlToValidate="TxtDonationamountexcepted" ErrorMessage="(10 Above)" 
                                ForeColor="White" MaximumValue="1000000" MinimumValue="10" Type="Integer"></asp:RangeValidator>
                                           </td>
            </tr>
             
                        <tr>
                            <td class="style5">
                                Amount Expected
                            </td>
                            <td bgcolor="#003300">
                            <asp:TextBox ID="TxtDonationamountexcepted" runat="server"></asp:TextBox></td>
                            <td bgcolor="#003300">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                                    ControlToValidate="TxtDonationamountexcepted"  ErrorMessage="*" runat="server" 
                                    ForeColor="White"></asp:RequiredFieldValidator>
                           
                </td>
            </tr>
                    
                <tr>
                            <td class="style5">
                                Description
                            </td>
                            <td bgcolor="#003300">
                            <asp:TextBox ID="TxtDonationDescription" runat="server"></asp:TextBox></td><td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
                                    ControlToValidate="TxtDonationDescription"  ErrorMessage="*" runat="server" 
                                    ForeColor="White"></asp:RequiredFieldValidator>
                            
                           
                </td>
            </tr>
            <tr>
                            <td class="style5">
                                &nbsp;Acquired Members Count
                            </td>
                            <td>
                            <asp:TextBox ID="TxtDonationAcquiredMembersCount" runat="server"></asp:TextBox></td><td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" 
                                    ControlToValidate="TxtDonationAcquiredMembersCount"  ErrorMessage="*" 
                                    runat="server" ForeColor="White"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator2" runat="server" MinimumValue="10" 
                                    MaximumValue="1000000" ControlToValidate="TxtDonationAcquiredMembersCount" 
                                    Type="Integer" ErrorMessage="(10 Above)" ForeColor="White"></asp:RangeValidator>
                           
                </td>
            </tr>
               <tr>
                            <td class="style5">
                                Minimum Amount Accepted
                            </td>
                            <td>
                            <asp:TextBox ID="TxtDonationMinimumAmountAccepted" runat="server"></asp:TextBox></td><td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" 
                                    ControlToValidate="TxtDonationMinimumAmountAccepted"  ErrorMessage="*" 
                                    runat="server" ForeColor="White"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator3" runat="server" MinimumValue="10" 
                                    MaximumValue="1000000" ControlToValidate="TxtDonationMinimumAmountAccepted" 
                                    Type="Integer" ErrorMessage="(10 Above)" ForeColor="White"></asp:RangeValidator>
                           
                </td>
            </tr>
             <tr>
        <td colspan="3" class="tableHeading">&nbsp;</td>
        
        </tr>
             <tr>
        <td colspan="3" class="style6">
        
            (* are mandatory)</td>
        
        </tr>
        <tr>
        <td colspan="3">
        
        <center>
        <asp:Button ID="btnAdd" runat="server" Text="Submit" style="font-weight: 700" 
                onclick="btnAdd_Click" />
     
        
               &nbsp;&nbsp;
     
        
               <asp:Button ID="btncancel" runat="server" Text="Cancel" 
                style="font-weight: 700" onclick="btncancel_Click" /></center>
        </td>
        </tr>
        </table>
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </center>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
