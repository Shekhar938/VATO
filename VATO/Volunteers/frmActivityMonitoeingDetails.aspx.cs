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

public partial class Volunteers_frmActivityMonitoeingDetails : System.Web.UI.Page
{
    Cls_ActivityMonitorDetails objActivityMonitor = new Cls_ActivityMonitorDetails();
    string s, s1;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetActivityMonitorId();
            }
        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            if (ddlMonitorID.SelectedIndex != 0)
            {
                objActivityMonitor.ActivityMonitorId = Convert.ToInt32(ddlMonitorID.SelectedValue);
                if (Session["ActivityImage"] != null)
                {
                    s = "~/ActivityImages/" + Session["ActivityImage"].ToString();
                }
                else
                {
                    s = "~/Upload/NoImage.jpg";
                }
                objActivityMonitor.ActivityImagefileName = s.ToString();
                objActivityMonitor.ActivityImagefileDescription = TxtImageDescription.Text;
                if (Session["VideoFile"] != null)
                {
                    s1 = "~/VideoFiles/" + Session["VideoFile"].ToString();
                }
                else
                {
                    s1 = "";
                }
                objActivityMonitor.ActivityImageVideofileName = s1;
                objActivityMonitor.ImageorVideofileHostedVolunteerId = Convert.ToInt32(Session["VolunteerId"]);


                int i = objActivityMonitor.InsertActivityMonitoringDetails();
                if (i > 0)
                {
                    Cleardata();
                    Session["ActivityImage"] = "";
                    Session["VideoFile"] = "";
                    LblError.Text = "Activity Monitoring Details Submitted.";
                }
                else
                {
                    LblError.Text = "Recorded Not Inserted Try Again";
                }
            }
        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        Cleardata();
    }
    void GetActivityMonitorId()
    {
        try
        {
            ddlMonitorID.Items.Clear();
            DataSet ds = objActivityMonitor.GetActivityMonitoringIdByVolunteerId(Convert.ToInt32(Session["VolunteerId"]));
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlMonitorID.DataSource = ds.Tables[0];
                ddlMonitorID.DataTextField = "ActivityMonitorId";
                ddlMonitorID.DataValueField = "ActivityMonitorId";
                ddlMonitorID.DataBind();
            }
            ddlMonitorID.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }
    void Cleardata()
    {
        TxtImageDescription.Text = "";
        ImageFile1.ClearImage();
        if (ddlMonitorID.Items.Count != 0)
            ddlMonitorID.SelectedIndex = 0;

    }
}
