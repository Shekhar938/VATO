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

public partial class Faculty_frmFacultyChat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            GetOnlineVolunteerInfo();
            GetOnlineMemberInfo ();
        }
    }

    #region Web Form Designer generated code

    override protected void OnInit(EventArgs e)
    {
        //
        // CODEGEN: This call is required by the ASP.NET Web Form Designer.
        //
        InitializeComponent();
        base.OnInit(e);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    /// 

    private void InitializeComponent()
    {

    }
    #endregion

    protected void BT_Send_Click(object sender, System.EventArgs e)
    {
        string sChannel = "1";
        string sUser = Session["UserName"].ToString() + "( " + Session["UserType"].ToString() + " )";
                
        if (TB_ToSend.Text.Length > 0)
        {
            Chat.AddMessage(sChannel,sUser,TB_ToSend.Text);
            TB_ToSend.Text = "";
        }
    }

    void GetOnlineVolunteerInfo()
    {
        try
        {
            DataSet ds = clsLogin.GetOnlineVolunteerData();
            if (ds.Tables[0].Rows.Count != 0)
            {
                grdFaculty.DataSource  = ds.Tables[0];
                grdFaculty.DataBind();
            }
            else
            {
                grdFaculty.EmptyDataText = "Volunteers not available to chat.";
                grdFaculty.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }

    void GetOnlineMemberInfo()
    {
        try
        {
            DataSet ds = clsLogin.GetOnlineMemberData();
            if (ds.Tables[0].Rows.Count != 0)
            {
                grdStudents.DataSource = ds.Tables[0];
                grdStudents.DataBind();
            }
            else
            {
                grdStudents.EmptyDataText = "Donors not available to chat.";
                grdStudents.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        try
        {
            GetOnlineMemberInfo();
            GetOnlineVolunteerInfo();
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }
}
