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

public partial class Members_frmMemberDiscussionforumMaster : System.Web.UI.Page
{
    Cls_MemberDiscussionForumMaster objmemberdiscussionforum = new Cls_MemberDiscussionForumMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            objmemberdiscussionforum.DiscussionDateClosed =Convert.ToDateTime (txtDiscussionClosedate.Text);
            objmemberdiscussionforum.MemberId = Convert.ToInt32(Session["VolunteerId"]);
            objmemberdiscussionforum.DisscussionTopicPorted = txtDiscussiontopic.Text;

            int i = objmemberdiscussionforum.InsertMemberDiscussionMaster();
            mainPanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainPanel.Enabled = true;
            if (i > 0)
            {
                ClearData();
                Response.Redirect("~/Volunteers/frmForumDiscussionDetails.aspx");
                lblMsg.Text = "Discussion forum Posted";
            }
            else
            {
                lblMsg.Text = "Error Process Try Again..";
            }
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
    public void ClearData()
    {
        txtDiscussionClosedate.Text = "";
        txtDiscussiontopic.Text = "";
        lblMsg.Text = "";
    }
}
