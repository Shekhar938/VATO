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

public partial class Admin_frmMemberQuestionAnswers : System.Web.UI.Page
{
    Cls_VillageVolunteerMaster objVillageVolunteerMaster = new Cls_VillageVolunteerMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetActivityId();
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

            objVillageVolunteerMaster.VolunteerId = Convert.ToInt32(ddlvolunteerID.SelectedValue );
            objVillageVolunteerMaster.VillageId = Convert.ToInt32(ddlVillageId.SelectedValue);

            objVillageVolunteerMaster.ActivityId = Convert.ToInt32(ddlActivityId.SelectedValue);





            int i = objVillageVolunteerMaster.InsertvillageVolunteermaster();
            if (i > 0)
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
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Cleardata();
    }
    protected void ddlvolunteerID_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    void GetvillageId()
    {
        try
        {
            ddlVillageId.Items.Clear();
            DataSet ds = objVillageVolunteerMaster.GetvillageId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlVillageId.DataSource = ds.Tables[0];
                ddlVillageId.DataTextField = "VillageName";
                ddlVillageId.DataValueField = "VillageId";
                ddlVillageId.DataBind();
            }
            ddlVillageId.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    void Getvolunteerid()
    {
        try
        {
            ddlvolunteerID.Items.Clear();
            DataSet ds = objVillageVolunteerMaster.GetvolunteerId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlvolunteerID .DataSource = ds.Tables[0];
                ddlvolunteerID .DataTextField = "VolunteerName";
                ddlvolunteerID .DataValueField = "VolunteerId";
                ddlvolunteerID .DataBind();
            }
            ddlvolunteerID.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
    void GetActivityId()
        {
            try
            {
                ddlActivityId.Items.Clear();
                DataSet ds = objVillageVolunteerMaster.GetActivityId() ;
                if (ds.Tables[0].Rows.Count != 0)
                {
                    ddlActivityId.DataSource = ds.Tables[0];
                    ddlActivityId.DataTextField = "ActivityName";
                    ddlActivityId.DataValueField = "ActivityId";
                    ddlActivityId.DataBind();
                }
                ddlActivityId.Items.Insert(0, "--Select One--");
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
    
    }
    void Cleardata() 
        {
            if (ddlActivityId.SelectedIndex!= 0)
                ddlActivityId.SelectedIndex = 0;
            if (ddlVillageId.SelectedIndex != 0)
                ddlVillageId.SelectedIndex = 0;
            if (ddlvolunteerID.SelectedIndex != 0)
                ddlvolunteerID.SelectedIndex = 0;
            TxtVolunteeraddress.Text = "";
    }

    protected void ddlvolunteerID_SelectedIndexChanged1(object sender, EventArgs e)
    {
        try
        {
            if (ddlvolunteerID.SelectedIndex != 0)
            {


                int VolunteerId = Convert.ToInt32(ddlvolunteerID.SelectedValue);
                DataSet ds = objVillageVolunteerMaster.GetVolunteerIdData(VolunteerId);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    TxtVolunteeraddress.Text = ds.Tables[0].Rows[0][7].ToString();


                }

            }
            else
            {
                Cleardata();
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
