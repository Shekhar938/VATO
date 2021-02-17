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


public partial class Admin_frmVillageDonationMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetActivityIddata();
                GetVillageIdData();
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
    Cls_VillageDonationsMaster  VillageDonationMaster = new Cls_VillageDonationsMaster ();

    void Cleardata()
    {
        TxtDonationAcquiredMembersCount.Text = "";
        if (ddlactivityid.Items.Count != 0)
            ddlactivityid.SelectedIndex = 0;
        if (ddlvillageid.Items.Count != 0)
            ddlvillageid.SelectedIndex = 0;
        TxtDonationamountexcepted.Text = "";
    
        TxtDonationDescription.Text = "";
        TxtDonationMinimumAmountAccepted.Text = "";
    }


    protected void ddlactivityid_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            //VillageDonationMaster.DonationRegDate = Convert.ToDateTime(TxtRegDate.Text);
            VillageDonationMaster.ActivityId = Convert.ToInt32(ddlactivityid.SelectedValue);
            VillageDonationMaster.VillageId = Convert.ToInt32(ddlvillageid.SelectedValue);
            VillageDonationMaster.DonationAmountexpected = Convert.ToDecimal(TxtDonationamountexcepted.Text);
     
            VillageDonationMaster.DonationDescription = TxtDonationDescription.Text;
            VillageDonationMaster.DonationAcquiredMembersCount = Convert.ToInt32(TxtDonationAcquiredMembersCount.Text);
            VillageDonationMaster.DonationMinimumAmountAccepted = Convert.ToDecimal(TxtDonationMinimumAmountAccepted.Text);
            int i = VillageDonationMaster.InsertVillageDonationMaster();
            if (i == 1)
            {
                Cleardata();
                lblError.Text = "Recorded Inserted";
            }
            else
            {
                lblError.Text = "Recorded Not Inserted Try Again";
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
       

    }

    void GetActivityIddata()
    {
        try
        {
            ddlactivityid.Items.Clear();
            DataSet ds = VillageDonationMaster.GetActivityIdData();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlactivityid.DataSource = ds.Tables[0];
                ddlactivityid.DataTextField = "ActivityName";
                ddlactivityid.DataValueField = "ActivityId";
                ddlactivityid.DataBind();
            }
            ddlactivityid.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
       
    }

    void GetVillageIdData()

    {
        try
        {
            ddlvillageid.Items.Clear();
            DataSet ds = VillageDonationMaster.GetVillageIdData();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlvillageid.DataSource = ds.Tables[0];
                ddlvillageid.DataTextField = "VillageName";
                ddlvillageid.DataValueField = "VillageId";
                ddlvillageid.DataBind();
            }
            ddlvillageid.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
   



    protected void btncancel_Click(object sender, EventArgs e)
    {
        Cleardata();
    }
  
}
