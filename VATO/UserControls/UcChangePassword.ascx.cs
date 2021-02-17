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
using BackToMyVillage;

public partial class UserControls_UcChangePassword : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void ClearFields()
    {
        txtOldPwd.Text = "";
        txtNewPwd.Text = "";
        txtConPwd.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            lblMsg.Text = "";
            string strCmdText1 = "select * from tbl_LoginMaster where Password='" + txtOldPwd.Text + "' and UserName='" + Convert.ToString(Session["UserName"]) + "'";
            DataSet ds=SqlHelper.ExecuteDataset(Connection.con , CommandType.Text, strCmdText1);
            if (ds.Tables[0].Rows.Count !=0)
            {
                string strComText2 = "update tbl_LoginMaster set Password='" + txtConPwd.Text + "' where UserName='" + Convert.ToString(Session["UserName"]) + "'";
                int i = SqlHelper.ExecuteNonQuery(Connection.con , CommandType.Text, strComText2);
                if (i == 1)
                {
                    lblMsg.Text = "Your password changed successfully..";
                    ClearFields();
                }
                else
                    lblMsg.Text = "Error Try again.";
            }
            else
                lblMsg.Text = "User Login Name and Password not matched";
        }
        catch (Exception ex)
        {
            lblMsg.Text = "Error: Get asp.net Teamsupport";
        }
    }
}
