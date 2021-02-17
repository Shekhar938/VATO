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

public partial class Members_ForumDiscussionDetails : System.Web.UI.Page
{
    Cls_MemberDiscussionForumMaster objmemberdiscussionmaster = new Cls_MemberDiscussionForumMaster();
    protected void Page_Load(object sender, EventArgs e)
    { int id;
        try
        {
            if (!IsPostBack)
            {
                Getdata();
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
           
        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "ClickNextpage")
            {
                Response.Redirect("~/Volunteers/frmforumAnswers.aspx?id=" + e.CommandArgument.ToString());
            }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            GridView1.PageIndex = e.NewPageIndex;
            Getdata();
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
    public void Getdata()
    {
        try
        {
            DataSet ds = Cls_MemberDiscussionForumMaster.ShowmemberDiscussionforummaster();
                if (ds.Tables[0].Rows.Count != 0)
                {
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    foreach (GridViewRow item in GridView1.Rows)
                    {
                        Label lbl = (Label)item.FindControl("lblQuestion");
                        GridView gv1 = (GridView)item.FindControl("GridView2");
                        DataSet ds1 = Cls_MemberDiscussionForumMaster.Showmemberdiscussionforumidwise(Convert.ToInt32(lbl.Text));
                        gv1.DataSource = ds1.Tables[0];
                        gv1.DataBind();

                    }
                }
        }
        catch (Exception ex)
        {

            lblError.Text = ex.Message;
        }
    }
}
