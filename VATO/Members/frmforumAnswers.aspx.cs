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

public partial class Members_frmforumAnswers : System.Web.UI.Page
{
    Cls_MemberDiscussionForumMaster objmemberdiscussion = new Cls_MemberDiscussionForumMaster();
    static int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                

                if (Request["id"] != null)
                {
                 id =Convert.ToInt32( Request["id"]);
                    DataSet ds = Cls_MemberDiscussionForumMaster.Showmemberdiscussiontopicid(id);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        lblQuestion.Text = ds.Tables[0].Rows[0][4].ToString();
                    }
                    else
                    {
                    
                    }
                }

            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("~/members/frmForumDiscussionDetails.aspx");
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
            objmemberdiscussion.MemberId =Convert.ToInt32( Session["MemberId"]);
            objmemberdiscussion.ResponseData = txtAnswertext.Text;
            objmemberdiscussion.DiscussionId = id;
            int i = objmemberdiscussion.InserDisscussionforumdetails();
            mainpanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainpanel.Enabled = true;
            if (i > 0)
            {
                txtAnswertext.Text = "";
                lblError.Text = "Sucessfully forum details Added.";
            }
            else
            {
                lblError.Text = "Error Process Try Again..";
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
