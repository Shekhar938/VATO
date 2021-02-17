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

public partial class Members_frmMemActQuestionRaiseMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                BindVillageId();
                BindActivityId();
               
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            clsMemberQuestions obj = new clsMemberQuestions();
            obj.ActivityId = Convert.ToInt32(ddlActivityName.SelectedValue);
            obj.VillageId = Convert.ToInt32(ddlVillage.SelectedValue);
            obj.QuestionDescription = txtDesc.Text;
            obj.MemberId = Convert.ToInt32(Session["MemberId"]);
            mainPanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainPanel.Enabled = true;
            string strMsg = obj.MemberActivityQuestionraiseMaster();
            ClearData();
            lblMsg.Text = strMsg;
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
                ddlVillage.DataSource = ds.Tables[0];
                ddlVillage.DataTextField = "VillageName";
                ddlVillage.DataValueField = "VillageId";
                ddlVillage.DataBind();
            }
            ddlVillage.Items.Insert(0, "--Select One--");
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

    void ClearData()
    {
        try
        {
            lblMsg.Text = "";
            txtDesc.Text = "";
            if (ddlActivityName.Items.Count != 0)
                ddlActivityName.SelectedIndex = 0;
            if (ddlVillage.Items.Count != 0)
                ddlVillage.SelectedIndex = 0;
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
