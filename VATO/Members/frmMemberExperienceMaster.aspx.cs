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

public partial class Members_frmMemberExperienceMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                BindActivityId();
                BindVillageId();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
    void BindVillageId()
    {
        try
        {
            DataSet ds = Cls_VillageMaster.GetAllVillageMaster();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlVillagename.DataSource = ds.Tables[0];
                ddlVillagename.DataTextField = "VillageName";
                ddlVillagename.DataValueField = "VillageId";
                ddlVillagename.DataBind();
            }
            ddlVillagename.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
    void BindActivityId()
    {
        try
        {
            DataSet ds = Cls_ActivityMaster.GetActivityId();
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlActivityName.DataSource = ds.Tables[0];
                ddlActivityName.DataTextField = "ActivityName";
                ddlActivityName.DataValueField = "ActivityId";
                ddlActivityName.DataBind();
            }
            ddlActivityName.Items.Insert(0, "--Select One--");
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
    clsMemberExp objMemExp;
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            objMemExp = new clsMemberExp();
            objMemExp.ActivityId = Convert.ToInt32(ddlActivityName.SelectedValue);
            objMemExp.ExperienceDescription = txtDesc.Text;
            objMemExp.MenberId = Convert.ToInt32(Session["MemberId"]);
            objMemExp.VillageId = Convert.ToInt32(ddlVillagename.SelectedValue);
            int Count = 0;
            for (int i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
            {
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    Count = Count + 1;
                }
            }
            objMemExp.RatingIdValue = Count;
            mainPanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainPanel.Enabled = true;
            int j = objMemExp.InsertMembersExperiencesMaster();
            if (j != 0)
            {
                ClearData();
                lblMsg.Text = "Your Experience Details submitted";
            }
            else
                lblMsg.Text = "Error in process, Try again.";
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }

    void ClearData()
    {
        try
        {
            lblMsg.Text = "";
            txtDesc.Text = "";
            if (ddlActivityName.Items.Count != 0)
                ddlActivityName.SelectedIndex = 0;
            if (ddlVillagename.Items.Count != 0)
                ddlVillagename.SelectedIndex = 0;
            for (int i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
            {
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    CheckBoxList1.Items[i].Selected = false;
                }
            }
            CheckBoxList1.Items[0].Selected = true;
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearData();
    }
}
