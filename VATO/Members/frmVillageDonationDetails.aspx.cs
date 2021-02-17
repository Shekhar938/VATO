using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


public partial class frmVillageDonationDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                
                GetDonationMasterdata();
                GetPaymentTypeId();
                GetVolunteerMasterId();
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
   
    Cls_VillageDonationDetails objDonationDetails = new Cls_VillageDonationDetails();
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            decimal minAmt = Convert.ToDecimal(TxtMinimumAmountAccepted.Text);
            decimal donAmt = Convert.ToDecimal(TxtAmountDonated.Text);
            if (donAmt >= minAmt)
            {
                objDonationDetails.DonationId = Convert.ToInt32(ddlDonationID.SelectedValue);
                objDonationDetails.ActivityId = Convert.ToInt32(ViewState["Activityid"]);
                objDonationDetails.VillageId = Convert.ToInt32(ViewState["VillageId"]);
                objDonationDetails.MemberIdorUserId = Convert.ToInt32(Session["MemberId"]);
                objDonationDetails.AmountDonated = Convert.ToDecimal(TxtAmountDonated.Text);
                objDonationDetails.RemarksforDonation = Convert.ToString(TxtremarksForDonation.Text);

                objDonationDetails.PaymentTypeId = Convert.ToInt32(ddlPaymenttypeid.SelectedValue);
                objDonationDetails.InteoducedVolunteerId = Convert.ToInt32(ddlIntroducedVolunteerid.SelectedValue);
                int i = objDonationDetails.InsertVillageDonationDetails();
                if (i > 0)
                {
                    Cleardata();
                    lblError.Text = "Recorded Inserted";
                    lblError.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblError.Text = "Recorded Not Inserted Try Again";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblError.Text = "Please enter amount more than min amount.";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
  
        }
        catch (Exception ex )
        {

            lblError.Text = ex.Message;
        }
        }
    void GetDonationMasterdata()
    {
        try
        {
            ddlDonationID.Items.Clear();
            DataSet ds = objDonationDetails.GetDonationMasterData();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlDonationID.DataSource = ds.Tables[0];
                //ddlDonationID.DataTextField = "VillageName";
                ddlDonationID.DataValueField = "DonationId";
                ddlDonationID.DataBind();
            }
            ddlDonationID.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {
            
           lblError.Text = ex.Message;
        }
    }
    void GetPaymentTypeId()
    {
        try
        {
            ddlPaymenttypeid.Items.Clear();
            DataSet ds = objDonationDetails.GetPaymentTypeId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlPaymenttypeid.DataSource = ds.Tables[0];
                ddlPaymenttypeid.DataTextField = "PaymentTypeName";
                ddlPaymenttypeid.DataValueField = "PaymentTypeId";
               ddlPaymenttypeid.DataBind();
            }
            ddlPaymenttypeid.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }

    void GetVolunteerMasterId()
    {
        try
        {
            ddlIntroducedVolunteerid .Items.Clear();
            DataSet ds = objDonationDetails.GetVolunteerMasterId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlIntroducedVolunteerid .DataSource = ds.Tables[0];
                ddlIntroducedVolunteerid.DataTextField = "VolunteerName";
                ddlIntroducedVolunteerid.DataValueField = "VolunteerId";
                ddlIntroducedVolunteerid.DataBind();
            }
            ddlIntroducedVolunteerid.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }

 
    void Cleardata()
    {
        TxtAmountDonated.Text = "";
        TxtActivityId.Text = "";
        TxtVillageId.Text = "";
        if (ddlDonationID .Items.Count != 0)
            ddlDonationID.SelectedIndex = 0;
        if (ddlPaymenttypeid .Items.Count != 0)
            ddlPaymenttypeid .SelectedIndex = 0;
        
        if (ddlIntroducedVolunteerid .Items.Count != 0)
            ddlIntroducedVolunteerid .SelectedIndex = 0;
        TxtremarksForDonation.Text = "";
        TxtMinimumAmountAccepted.Text = "";
        TxtAmountCollectedtillNow.Text = "";

        TxtDonationAmountExpected.Text = "";
       
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Cleardata();
       
    }
    protected void ddlDonationID_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlDonationID.SelectedIndex != 0)
            {


                int BrandId = Convert.ToInt32(ddlDonationID.SelectedValue);
                DataSet ds = objDonationDetails.GetDonationIdData(BrandId);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    TxtVillageId.Text = ds.Tables[0].Rows[0][3].ToString();
                   
                    TxtActivityId.Text = ds.Tables[0].Rows[0][0].ToString();
                    TxtDonationAmountExpected.Text = ds.Tables[0].Rows[0][4].ToString();
                    TxtAmountCollectedtillNow.Text = ds.Tables[0].Rows[0][5].ToString();
                    TxtMinimumAmountAccepted.Text = ds.Tables[0].Rows[0][6].ToString();
                    ViewState["Activityid"] = ds.Tables[0].Rows[0][1].ToString();
                    ViewState["VillageId"] = ds.Tables[0].Rows[0][2].ToString();
                   
                }
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
       
    }
}
