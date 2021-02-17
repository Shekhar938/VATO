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

public partial class Members_frmComposeMail : System.Web.UI.Page
{
    Cls_EmailMaster objEmailmaster = new Cls_EmailMaster();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                
            }
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
            string str = "";
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] data = encoding.GetBytes(str);

            objEmailmaster.EmailSenderId = Convert.ToInt32(Session["MemberId"]);
            objEmailmaster.EMailBodyMsg = txtbody.Text;
            objEmailmaster.EmailSubjectText = txtsubject.Text;
            objEmailmaster.EmailReciptedId = Convert.ToInt32(ddlto.SelectedValue);
            if (Session["FileName"] != null && Session["FileContent"] != null)
            {
                objEmailmaster.EmailAttachFileName = Convert.ToString(Session["FileName"]);
                objEmailmaster.EmailAttachFileContent = (byte[])Session["FileContent"];
            }
            else
            {
                objEmailmaster.EmailAttachFileName = "No FIle";
                objEmailmaster.EmailAttachFileContent = data ;
            }
            mainPanel.Enabled = false;
            System.Threading.Thread.Sleep(2000);
            mainPanel.Enabled = true;
            int i = objEmailmaster.InsertEmailMaster();
            if (i > 0)
            {
                ClearData();
                lblMsg.Text = "Sending Email Sucessfully..";
            }
            else
            {
                lblMsg.Text = "Sending Failed..";
            }
        }
        catch (Exception ex)
        {

            lblMsg.Text = ex.Message;
        }


    }

    public void ClearData()
    {
        Session["FileName"] = "";
        Session["FileContent"] = "";
        txtsubject.Text = "";
        txtbody.Text = "";
        if (ddlto.SelectedIndex != 0)
            ddlto.SelectedIndex = 0;
        lblMsg.Text = "";
    }


    protected void rdbMembers_CheckedChanged(object sender, EventArgs e)
    {

        try
        {
            DataSet ds = Cls_EmailMaster.ShowAdminEmails();

            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlto.DataSource = ds.Tables[0];
                ddlto.DataTextField = "Username";
                ddlto.DataValueField = "Vole_mem_id";
                ddlto.DataBind();
                ddlto.Items.Insert(0, "--Select MailId--");
            }
            else
            {
                ddlto.Items.Clear();
                ddlto.Items.Insert(0, "--Select MailId--");
            }
            txtbody.Text = "";
            txtsubject.Text = "";
            lblMsg.Text = "";
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
    protected void rdbVolunteers_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = Cls_EmailMaster.ShowVolunteerEmails();

            if (ds.Tables[0].Rows.Count != 0)
            {
                ddlto.DataSource = ds.Tables[0];
                ddlto.DataTextField = "Username";
                ddlto.DataValueField = "Vole_mem_id";
                ddlto.DataBind();
                ddlto.Items.Insert(0, "--Select MailId--");
            }
            else
            {
                ddlto.Items.Clear();
                ddlto.Items.Insert(0, "--Select MailId--");
            }
            txtbody.Text = "";
            txtsubject.Text = "";
            lblMsg.Text = "";
        }
        catch (Exception ex)
        {

            lblMsg.Text = ex.Message;
        }
    }
}
