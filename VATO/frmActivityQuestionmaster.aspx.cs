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

public partial class frmActivityQuestionmaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                BindActivityId();
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            clsMemberQuestions obj = new clsMemberQuestions();
            obj.ActivityId = Convert.ToInt32(ddlActivityName.SelectedValue);
            obj.QuestionDescription = txtDesc.Text;
            int j = obj.InsertActivityQuestionMaster();
            mainPanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainPanel.Enabled = true;
            if (j == 1)
            {
                ClearData();
                lblMsg.Text = "Your Question Submitted...";
            }
            else
                lblMsg.Text = "Error in submitting Data.";
        }
        catch (Exception ex)
        {
            mainPanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainPanel.Enabled = true;
            lblMsg.Text = ex.Message;
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearData();
    }

    void ClearData()
    {
        try
        {
            lblMsg.Text = "";
            txtDesc.Text = "";
            if (ddlActivityName.Items.Count != 0)
                ddlActivityName.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
}
