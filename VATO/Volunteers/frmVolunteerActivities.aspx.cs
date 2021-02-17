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

public partial class Volunteers_frmVolunteerActivities : System.Web.UI.Page
{
    Cls_VoluntereActivities objvolunteerActivitees = new Cls_VoluntereActivities();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetCaseStudyId();
                GetvillageId();
                Getvolunteerid();
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            if (ddlvillageId.SelectedIndex != 0 && ddlCasestudyId.SelectedIndex != 0)
            {
                objvolunteerActivitees.VolunteerId = Convert.ToInt32(ddlvolunteerID.SelectedValue);
                objvolunteerActivitees.ActivityConductedDate = Convert.ToDateTime(TxtActivityconduceddate.Text);
                objvolunteerActivitees.VillageId = Convert.ToInt32(ddlvillageId.SelectedValue);
                objvolunteerActivitees.CaseStudyId = Convert.ToInt32(ddlCasestudyId.SelectedValue);
                objvolunteerActivitees.CaseStudyDetailedDescription = TxtcasestudyDescription.Text;
                objvolunteerActivitees.CaseStudyOutCome = TxtCasestudyOutCome.Text;


                int i = objvolunteerActivitees.InsertVolunteerActivities();
                if (i > 0)
                {
                    Cleardata();
                    lblError.Text = "Activity Information Submitted.";
                }
                else
                {
                    lblError.Text = "Recorded Not Inserted Try Again";
                }
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {

    }
    void Cleardata()
    {
        TxtActivityconduceddate.Text = "";
        TxtcasestudyDescription.Text = "";
        TxtCasestudyOutCome.Text = "";
        if (ddlvillageId.Items.Count != 0)
            ddlvillageId.SelectedIndex = 0;
        if (ddlvolunteerID.Items.Count != 0)
            ddlvolunteerID.SelectedIndex = 0;
        if (ddlCasestudyId.Items.Count != 0)
            ddlCasestudyId.SelectedIndex = 0;



    }
    void Getvolunteerid()
    {
        try
        {
            ddlvolunteerID.Items.Clear();
            DataSet ds = objvolunteerActivitees.GetvolunteerId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlvolunteerID.DataSource = ds.Tables[0];
                ddlvolunteerID.DataTextField = "VolunteerName";
                ddlvolunteerID.DataValueField = "VolunteerId";
                ddlvolunteerID.DataBind();
            }
            ddlvolunteerID.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
    void GetvillageId()
    {
        try
        {
            ddlvillageId.Items.Clear();
            DataSet ds = objvolunteerActivitees.GetvillageId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlvillageId.DataSource = ds.Tables[0];
                ddlvillageId.DataTextField = "VillageName";
                ddlvillageId.DataValueField = "VillageId";
                ddlvillageId.DataBind();
            }
            ddlvillageId.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    void GetCaseStudyId()
    {
        try
        {
            ddlCasestudyId.Items.Clear();
            DataSet ds = objvolunteerActivitees.GetCaseStudyId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlCasestudyId.DataSource = ds.Tables[0];
                ddlCasestudyId.DataTextField = "CaseStudyType";
                ddlCasestudyId.DataValueField = "CaseStudyId";
                ddlCasestudyId.DataBind();
            }
            ddlCasestudyId.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
