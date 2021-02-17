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

public partial class Members_frmActivityMonitoringDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int Id = Convert.ToInt32(e.CommandArgument);
        DataSet ds = clsMemberExp.GetAcitivityCompletionData(Id);
        if (ds.Tables[0].Rows.Count != 0)
        {
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }
        else
        {
            GridView2.EmptyDataText = "No Records Found.";
            GridView2.DataBind();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
