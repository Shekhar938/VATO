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

public partial class Volunteers_frmVolenteerInbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
               
                Getdata();
            }
        }
        catch (Exception ex)
        {

            lblMsg.Text = ex.Message;
        }
    }
    protected void GridInboxdetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            mainPanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainPanel.Enabled = true;
            int id = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("~/Volunteers/frmVolunteerShowInboxDetails.aspx?id=" + id);

        }
        catch (Exception ex)
        {

            lblMsg.Text = ex.Message;
        }
    }
    protected void GridInboxdetails_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label l1 = (Label)e.Row.FindControl("lblReadstatus");
            LinkButton link1 = (LinkButton)e.Row.FindControl("linkSendername");
            LinkButton link2 = (LinkButton)e.Row.FindControl("linksubject");
            LinkButton link3 = (LinkButton)e.Row.FindControl("linkDate");
            if (l1.Text == "True")
            {
                link1.Font.Bold = false;
                link2.Font.Bold = false;
                link3.Font.Bold = false;
            }
        }
    }
    public void chkSelectAll_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chk;
        foreach (GridViewRow rowItem in GridInboxdetails.Rows)
        {
            chk = (CheckBox)(rowItem.Cells[0].FindControl("chk1"));
            chk.Checked = ((CheckBox)sender).Checked;
        }
    }
    CheckBox chk;
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            mainPanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainPanel.Enabled = true;
            foreach (GridViewRow item in GridInboxdetails.Rows)
            {
                chk = (CheckBox)item.FindControl("chk1");


                if (chk.Checked)
                {
                    Label id = (Label)item.FindControl("lblid");
                    Cls_EmailMaster.UpdateEmailDeleteStatusInbox(Convert.ToInt32(id.Text));
                    Getdata();
                    lblMsg.Text = "";
                    lblMsg.Visible = false;

                }
                else
                {
                    lblMsg.Text = "Please Atleast One record is delete..";
                    lblMsg.Visible = true;
                }
            }



        }


        catch (Exception ex)
        {

            lblMsg.Text = ex.Message;
        }

    }
    public void Getdata()
    {
        try
        {
            GridInboxdetails.DataSource = Cls_EmailMaster.ShowInboxdetails(Convert.ToInt32(Session["VolunteerId"]));
            GridInboxdetails.DataBind();
            lblMsg.Text = "";
        }
        catch (Exception ex)
        {

            lblMsg.Text = ex.Message;
        }
    }
}
