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

public partial class Volunteers_frmActivityQuestionAnswerMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAllQuestions();
        }
    }

    void BindAllQuestions()
    {
        try
        {
            DataSet ds = clsMemberQuestions.GetAllQuestionsToanswer();
            Cache["Data"] = ds;
            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlQuestionId.DataSource = ds.Tables[0];
                ddlQuestionId.DataTextField = "QuestionId";
                ddlQuestionId.DataValueField = "QuestionId";
                ddlQuestionId.DataBind();
            }
            ddlQuestionId.Items.Insert(0, "--Select One--");
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
            obj.ActivityId = Convert.ToInt32(ViewState["ActivityId"]);
            obj.QuestionId = Convert.ToInt32(ddlQuestionId.SelectedValue);
            obj.strAnswerProvided = txtAnswer.Text;
            obj.Description = txtFileDesc.Text;
            if (ViewState["AttachFile"] != "")
            {
                obj.DocFileName = Convert.ToString(ViewState["AttachFile"]);
            }
            else
                obj.DocFileName = Convert.ToString("No File");
            int i = obj.InsertActivityQuestionAnswerMaster();

            System.Threading.Thread.Sleep(2000);
            if (i == 1)
            {
                lblMsg.Text = "Your Answer Posted..";
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }

    private void ClearData()
    {
        try
        {
            txtAnswer.Text = "";
            txtDesc.Text = "";
            ViewState["AttachFile"] = "";
            txtFileDesc.Text = "";
            if (ddlQuestionId.Items.Count != 0)
                ddlQuestionId.SelectedIndex = 0;
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

    protected void ddlQuestionId_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlQuestionId.SelectedIndex != 0)
            {
                DataSet ds = (DataSet)Cache["Data"];
                if (ds.Tables[0].Rows.Count != 0)
                {
                    DataRow dRow = ds.Tables[0].Select("QuestionId=" + Convert.ToInt32(ddlQuestionId.SelectedValue))[0];
                    lblActivityName.Text = dRow[1].ToString();
                    txtDesc.Text = dRow[2].ToString();
                    ViewState["ActivityId"] = dRow[3].ToString();
                }
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }

    protected void btnAttach_Click(object sender, EventArgs e)
    {
        try
        {
            ViewState["AttachFile"] = "~/DocumentFiles/" + FileUpload1.FileName;
            FileUpload1.SaveAs(Server.MapPath("~/DocumentFiles/" + FileUpload1.FileName));
            System.Threading.Thread.Sleep(3000);
            lblMsg.Text = "File Attached..";
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
}
